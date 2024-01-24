using L2ARAutomationSerialPort;
using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace L2PortsCommand
{
    class SerialCommands
    {
        SerialPort serialPort;

        FormSerialPortAutomation frmApp = FormSerialPortAutomation.getInstance();

        public void sendSerialComandAndRead(string serialCmd, string stationType)
        {
            frmApp.textBoxResult.Text += ">" + Environment.NewLine;
            var portnames = SerialPort.GetPortNames();

            foreach (var port in portnames)
            {
                //MessageBox.Show("Porta Disponivel: " + port.ToString());
            }
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

                serialPort.Open();
                serialPort.WriteLine(string.Format("{0}\r\n", serialCmd));
                if (stationType == "L2AR")
                    frmApp.textBoxResult.Text += "Response:" + serialPort.ReadExisting();
                else
                    frmApp.textBoxResult.Text += "Response:" + serialPort.ReadLine();

                if (serialPort.IsOpen)
                    serialPort.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }
    }
}
