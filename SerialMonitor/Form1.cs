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
        /// <summary>
        /// The comport to use
        /// </summary>
        SerialPort comPort;

        /// <summary>
        /// Whether we are monitoring at the moment or not
        /// </summary>
        bool monitoring = false;
        public Form1()
        {
            InitializeComponent();
            pupulateSelectionBox();
        }

        /// <summary>
        /// Gets all comports available on the system
        /// </summary>
        void pupulateSelectionBox()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comComboBox.Items.Add(port);
            }
        }


        /// <summary>
        /// Refresh the available comports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            comComboBox.Items.Clear();
            pupulateSelectionBox();
        }

        /// <summary>
        /// Connects to the selected comport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    connectButton.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                monitoring = false;
                comPort.Close();
                connectButton.Text = "Connect";
            }

        }

        /// <summary>
        /// Handles the recieving of serial data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String indata = sp.ReadExisting();
            populateTextBox(indata);        
        }

        /// <summary>
        /// Adds the data recieved by the comport to the text box
        /// </summary>
        /// <param name="message">The message we recieved</param>
        public void populateTextBox(String message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<String>(populateTextBox), new object[] { message });
            }
            else
            {
                serialTextBox.Text += message;
                serialTextBox.SelectionStart = serialTextBox.Text.Length;
                serialTextBox.ScrollToCaret();
                serialTextBox.Refresh();
            }
        }

        /// <summary>
        /// Sends a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialMessageBox.Text != "")
                {
                    comPort.Write(serialMessageBox.Text + '\n');
                    serialMessageBox.Text = "";
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            serialTextBox.Text = "";
        }
    }
}
