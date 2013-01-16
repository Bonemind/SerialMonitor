using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialMonitor
{
    public partial class Form1 : Form
    {
        SerialPort comPort;
        bool monitoring = false;
        public Form1()
        {
            InitializeComponent();
            pupulateSelectionBox();
        }

        void pupulateSelectionBox()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comComboBox.Items.Add(port);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            comComboBox.Items.Clear();
            pupulateSelectionBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!monitoring)
            {
                comPort = new SerialPort(comComboBox.GetItemText(comComboBox.SelectedItem));
                try
                {
                    comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    comPort.Open();
                    serialTextBox.Text += "Connected to comport\r\n";
                    monitoring = true;
                    button1.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    serialTextBox.Text += ex.Message + "\r\n";
                }
            }
            else
            {
                monitoring = false;
                comPort.Close();
                button1.Text = "Connect";
            }

        }
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String indata = sp.ReadExisting();
            populateTextBox(indata);        
        }

        public void populateTextBox(String message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<String>(populateTextBox), new object[] { message });
            }
            else
            {
                serialTextBox.Text += message + Environment.NewLine;
                serialTextBox.SelectionStart = serialTextBox.Text.Length;
                serialTextBox.ScrollToCaret();
                serialTextBox.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialMessageBox.Text != "")
                {
                    comPort.Write(serialMessageBox.Text + '\n');
                    serialMessageBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a message");
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
