using L2ARAutomationSerialPort;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace L2PortsCommand
{
    class SerialCommands
    {
        SerialPort serialPort;

        FormSerialPortAutomation frmApp = FormSerialPortAutomation.getInstance();
        public void sendSerialComand(string serialCmd)
        {
            frmApp.textBoxResult.Text += "-> Write" + Environment.NewLine;
            try
            {
                frmApp.textBoxResult.Text += serialCmd + Environment.NewLine;
                Application.DoEvents();

                serialPort = new SerialPort(frmApp.comboBoxPorts.Text);
                serialPort.BaudRate = int.Parse(frmApp.comboBoxBoundRate.Text);
                serialPort.DataBits = int.Parse(frmApp.comboBoxDataBits.Text);
                serialPort.DtrEnable = false;
                serialPort.RtsEnable = false;
                serialPort.ReadTimeout = 10000;
                serialPort.WriteTimeout = 10000;
                serialPort.Parity = Parity.None;


                if (frmApp.comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;
                if (frmApp.comboBoxStopBits.Text == "Two")
                    serialPort.StopBits = StopBits.Two;

                /* serialPort.Open();
                 serialPort.Write(serialCmd);


                 if (serialPort.IsOpen)
                     serialPort.Close();
 */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            
        }
        public void sendSerialComandAndRead(string serialCmd)
        {
            frmApp.textBoxResult.Text += "-> Write" + Environment.NewLine;
            try
            {
                frmApp.textBoxResult.Text += serialCmd + Environment.NewLine;
                Application.DoEvents();

                serialPort = new SerialPort(frmApp.comboBoxPorts.Text);
                serialPort.BaudRate = int.Parse(frmApp.comboBoxBoundRate.Text);
                serialPort.DataBits = int.Parse(frmApp.comboBoxDataBits.Text);
                serialPort.DtrEnable = false;
                serialPort.RtsEnable = false;
                serialPort.ReadTimeout = 1000;
                serialPort.WriteTimeout = 1000;
                serialPort.Parity = Parity.None;


                if (frmApp.comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;
                if (frmApp.comboBoxStopBits.Text == "Two")
                    serialPort.StopBits = StopBits.Two;

                /* serialPort.Open();
                 serialPort.Write(serialCmd);
                 frmApp.textBoxResult.Text += "Response:"  + serialPort.ReadExisting();


                 if (serialPort.IsOpen)
                     serialPort.Close();
 */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }
    }
}
