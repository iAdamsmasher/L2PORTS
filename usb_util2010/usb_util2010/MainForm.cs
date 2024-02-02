using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PnPDeviceManagement;
using System.Reflection;

namespace usb_util2010
{
    public partial class MainForm : Form
    {
        USBUtil util;
        PnPDeviceManager PhoneManager;
        EventListener Listener;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            util = new USBUtil(this);
            PhoneManager = util.PhoneManager;
            //Listener = new EventListener(this,util, PhoneManager);

            AssemblyInformationalVersionAttribute[] attr = Assembly
                .GetEntryAssembly()
                .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false) 
                as AssemblyInformationalVersionAttribute[];

            // {xli} 08/14
            // Check the existence of engine.dll file in C:\NexTest2010\SourceCode\utils\usb_util2010\usb_util2010\bin\Debug directory.
            if (!File.Exists("engine.dll"))
            {
                string CurrPath = Directory.GetCurrentDirectory();
                this.EventInfoTextBox.Text += "Missing engine.dll file!This will cause trouble in execution, please add engine.dll file in " + CurrPath;
            }
            this.Text += " - " + attr[0].InformationalVersion;
        }

        public void UpdatePortBox(int newPort, bool USB2)
        {
            lock (Usb2PortBox)
            {
                Usb2PortBox.Value = newPort;
                Usb2PortBox.Enabled = false;
                SetUSB2PortButton.Enabled = false;
            }
        }

        private void ChangeUSB2PortButton_Click(object sender, EventArgs e)
        {
            if (Usb2PortBox.Enabled == false)
            {
                if ((util.USBEvents[util.USBEvents.Count - 1]).Prefix == null || (util.USBEvents[util.USBEvents.Count - 1]).Prefix.Equals(String.Empty))
                {
                    MessageBox.Show("Event has no HWPortID");
                    return;
                }

                //ChangeUSB2PortButton.Text = "Cancel";
                Usb2PortBox.Enabled = true;
                SetUSB2PortButton.Enabled = true;
                
            }
            else
            {
                ChangeUSB2PortButton.Text = "Change";
                Usb2PortBox.Enabled = false;
                SetUSB2PortButton.Enabled = false;                
            }
            
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            //Application.Exit();
        }

        private void SetUSB2PortButton_Click(object sender, EventArgs e)
        {
            int newPort = (int)Usb2PortBox.Value;
            if (!((0 <= newPort && newPort <= 203)))
            {
                MessageBox.Show("Port number must be in the ranges 1 to 203. It can also be set to 0 to be unassigned");
                return;
            }
            Usb2PortBox.Enabled = false;
            SetUSB2PortButton.Enabled = false;

            ChangeUSB2PortButton.Text = "Change";
            PathPrefix.AssignPathPrefixToPort((util.USBEvents[util.USBEvents.Count - 1]).Prefix, newPort, EventListener.USBSpeed);
        }

        private void EventHistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            USBEventInfo selectedEvent = util.USBEvents[util.USBEvents.Count - 1]; 
            EventInfoTextBox.Text = selectedEvent.InfoString;
            UpdatePortBox(PathPrefix.FindUSBPortFromRegistry(selectedEvent.Prefix, EventListener.USBSpeed), EventListener.USBSpeed);
        }

        private void EventInfoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateEventInfo()
        {
            USBEventInfo currentEvent = util.USBEvents[util.USBEvents.Count - 1];
            EventInfoTextBox.Text = currentEvent.InfoString;
        }


    }
}
