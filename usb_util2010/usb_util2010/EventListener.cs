using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using PnPDeviceManagement;
using System.ComponentModel;
using System.Windows.Forms;

namespace usb_util2010
{
    public class EventListener
    {
        MainForm CallingForm;
        USBUtil UsbUtil;
        private PnPDeviceManager PhoneEventManager;
        private static bool HighSpeedUSB;

        //public delegate void PnPDelegateType(object sender, object args, Dictionary<string, string> values);

        public delegate void UpdatePortBox(int newPort, bool USB2);
        public delegate void UpdateEventInfoDelegate();
        public delegate void HandleNewUSBEventDelegate(string EventInfoString);
        Delegate PnPDelegate;

        /// <summary>
        /// Initialize the EventListener.
        /// </summary>
        /// <param name="sender">The object that created this instance of EventListener</param>
        /// <param name="portNumber"></param>
        /// <param name="manager"></param>
        public EventListener(MainForm sender, USBUtil UsbUtil, PnPDeviceManager manager)
        {
            //Store the sender and manager for future access
            CallingForm = sender;
            this.UsbUtil = UsbUtil;
            PhoneEventManager = manager;

            //Reflectively get the HandleEvent method and store it in a MethodInfo
            //so that we can use it as a method for a Delegate.
            MethodInfo MIHandler = typeof(EventListener).GetMethod("HandleEvent", BindingFlags.Public | BindingFlags.Instance);

            //Create the delegate
            PnPDelegate = Delegate.CreateDelegate(typeof(PnPDeviceManager.PublishPnPEvent), this, MIHandler);

            //Let the Event Manager know about the Delegate so that it can be called
            PhoneEventManager.AddPublishEventHandler((PnPDeviceManager.PublishPnPEvent)PnPDelegate);
        }

        /// <summary>
        /// This event is raised when there is a USB_ARRIVAL or USB_REMOVAL.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <param name="values">Contains information about the phone</param>
        public void HandleEvent(object sender, object args, Dictionary<string, string> values)
        {            
            PnPDeviceManagement.PnPEventArgs eventArgs = args as PnPDeviceManagement.PnPEventArgs;

            StringBuilder EventInfoString = new StringBuilder();
            foreach (KeyValuePair<string, string> pair in values)
            {
                EventInfoString.Append(pair.Key + ": " + pair.Value + Environment.NewLine + Environment.NewLine);
            }
            object[] parameters = new object[1];
            parameters[0] = EventInfoString.ToString();
            //CallingForm.Invoke(new HandleNewUSBEventDelegate(CallingForm.HandleNewUSBEvent), parameters);

            string HWPortID;
            values.TryGetValue("HWPortId", out HWPortID);
            string USBspeed;
            values.TryGetValue("DeviceSpeed", out USBspeed);

            if ("HIGH" == USBspeed) EventListener.USBSpeed = true;
            else EventListener.USBSpeed = false;

            //Update history while accounting for possible duplicates
            if(UsbUtil.USBEvents.Count==0 || !UsbUtil.USBEvents[UsbUtil.USBEvents.Count-1].InfoString.Equals(EventInfoString.ToString()))
            {                
                UsbUtil.USBEvents.Add(new USBEventInfo(HWPortID, eventArgs.Type, EventInfoString.ToString()));
            }

            parameters = new object[2];
            parameters[0] = PathPrefix.FindUSBPortFromRegistry(HWPortID, EventListener.USBSpeed);
            parameters[1] = EventListener.USBSpeed;
            CallingForm.Invoke(new UpdatePortBox(CallingForm.UpdatePortBox), parameters);
            CallingForm.Invoke(new UpdateEventInfoDelegate(CallingForm.UpdateEventInfo), null);     
        }

        public void Exit()
        {
            PhoneEventManager.RemovePublishEventHandler((PnPDeviceManager.PublishPnPEvent)PnPDelegate);
            Application.Exit();
        }
        public static bool USBSpeed
        {
            get
            {
                return HighSpeedUSB;
            }
            set
            {
                HighSpeedUSB = value;
            }
        }

    }
}
