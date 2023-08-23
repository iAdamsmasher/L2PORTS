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
                serialPort.ReadTimeout = 50;
                serialPort.WriteTimeout = 50;
                serialPort.Parity = Parity.None;

                if (frmApp.comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;
                if (frmApp.comboBoxStopBits.Text == "Two")
                    serialPort.StopBits = StopBits.Two;

                serialPort.Open();
                serialPort.WriteLine(string.Format("{0}\r\n", serialCmd));
                frmApp.textBoxResult.Text += "Response:" + serialPort.ReadExisting();

                if (serialPort.IsOpen)
                    serialPort.Close();

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
                serialPort.ReadTimeout = 50;
                serialPort.WriteTimeout = 50;
                serialPort.Parity = Parity.None;

                if (frmApp.comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;
                if (frmApp.comboBoxStopBits.Text == "Two")
                    serialPort.StopBits = StopBits.Two;

                serialPort.Open();
                serialPort.WriteLine(string.Format("{0}\r\n", serialCmd));
                frmApp.textBoxResult.Text += "Response:" + serialPort.ReadExisting();

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
