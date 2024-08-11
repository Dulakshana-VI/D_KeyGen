using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_KeyGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string macAddress = "";
            string enkey = "b14ca5898a4e4133bbce2ea2315a1916";
            //foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            //{
            //    if (nic.OperationalStatus == OperationalStatus.Up)
            //    {
            //        macAddress += nic.GetPhysicalAddress().ToString() + " ";
            //    }
            //}
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    macAddress += nic.GetPhysicalAddress().ToString() + ",";
                }
            }

            string encrypted = AesOperation.EncryptString(enkey, macAddress);

            textBox1.Text = encrypted;


        }
    }
}
