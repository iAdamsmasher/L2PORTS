using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PnPDeviceManagement;

namespace usb_util2010
{
    public class USBEventInfo
    {
        public string InfoString {private set; get;}
        public string Prefix { private set; get; }
        PnPEventArgs.PnPEventType EventType;

        public USBEventInfo(string prefix, PnPEventArgs.PnPEventType eventType, string infoString)
        {
            this.InfoString = infoString;
            this.Prefix = prefix;
            this.EventType = eventType;
        }

        public override string ToString()
        {
            if (EventType == PnPEventArgs.PnPEventType.USB_ARRIVAL)
            {
                return "[ARRIVAL] " + Prefix;
            }
            return "[REMOVAL] " + Prefix;            
        }
    }
}
