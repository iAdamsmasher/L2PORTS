using L2ARAutomationSerialPort;
using NationalInstruments.VisaNS;
using System;
using System.Windows.Forms;

namespace L2PortsCommand
{
    class PowerSupply
    {
        FormSerialPortAutomation frmApp = FormSerialPortAutomation.getInstance();
        public MessageBasedSession Equipment;

        public bool PowerSupplyCommands()
        {
            frmApp.textBoxResult.Text += ">" + Environment.NewLine;
            frmApp.textBoxResult.Select(frmApp.textBoxResult.Text.Length - 1, 0);
            frmApp.textBoxResult.ScrollToCaret();
            Application.DoEvents();

            try
            {
                Equipment = new MessageBasedSession(frmApp.textBoxAddress.Text);
                Equipment.Write("VOLT " + frmApp.comboBoxVolt.Text + ";*OPC?"); // write to instrument
                string res = Equipment.ReadString();
                Equipment.Write("CURR:LIM:VAL " + frmApp.comboBoxCurr.Text + ";*OPC?"); // write to instrument
                res += Equipment.ReadString();
                Equipment.Write("OUTP On;*OPC?"); // write to instrument
                res += Equipment.ReadString();
                if (res == "1\n1\n1\n")
                {
                    frmApp.textBoxResult.Text += "Power supply Updated" + Environment.NewLine;
                    frmApp.textBoxResult.Select(frmApp.textBoxResult.Text.Length - 1, 0);
                    frmApp.textBoxResult.ScrollToCaret();
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Power supply not found!");
                frmApp.textBoxResult.Text += "Power supply not found!" + Environment.NewLine;
                frmApp.textBoxResult.Select(frmApp.textBoxResult.Text.Length - 1, 0);
                frmApp.textBoxResult.ScrollToCaret();
                return false;
            }
        }
    }
}
