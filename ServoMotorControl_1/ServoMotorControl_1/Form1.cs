using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ServoMotorControl_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          groupBox_servoposition.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                int int_degree=trackBar_degree.Value;
                serialPort1.Write(int_degree.ToString()+"\n");
                label_degree.Text = string.Format("degree= {0}", int_degree);
                textBox_degree.Text = int_degree.ToString();
            }
        }

        private void comboBox_portlist_DropDown(object sender, EventArgs e)
        {
            string[] portlist= SerialPort.GetPortNames();
            comboBox_portlist.Items.Clear();
            comboBox_portlist.Items.AddRange(portlist);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_portlist.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();
                groupBox_servoposition.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                    

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) 
            {
                string str_degree =textBox_degree.Text;
                trackBar_degree.Value = Convert.ToInt32(str_degree);
                serialPort1.Write(str_degree+"\n");
                label_degree.Text = "Degree = " + str_degree+ "°";
               
            }
        }

        private void textBox_degree_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("1#");
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("0#");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Close();  

        }
    }
}
