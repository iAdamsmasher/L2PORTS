using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PnPDeviceManagement;

namespace usb_util2010
{
    public class USBUtil
    {
        MainForm ParentForm;
        public PnPDeviceManager PhoneManager {private set; get;}
        EventListener Listener;

        public List<USBEventInfo> USBEvents { get; set; }

        public USBUtil(MainForm callingForm)
        {
            Initialize(callingForm);
            USBEvents = new List<USBEventInfo>();
            
        }
        
        public void Initialize(MainForm callingForm)
        {
            ParentForm = callingForm;
            PhoneManager = new PnPDeviceManager();
            Listener = new EventListener(callingForm, this, PhoneManager);
        }
    }
}
