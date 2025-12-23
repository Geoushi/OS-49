using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace OS_49
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ClearList()
        {
            listBox1.Items.Clear();
        }

        // 1. Basic Info
        private void btnBasicInfo_Click(object sender, EventArgs e)
        {
            ClearList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                listBox1.Items.Add("Name: " + obj["Name"]);
                listBox1.Items.Add("Domain: " + obj["Domain"]);
                listBox1.Items.Add("Model: " + obj["Model"]);
            }
        }

        // 2. CPU Info
        private void btnCPU_Click(object sender, EventArgs e)
        {
            ClearList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                listBox1.Items.Add("CPU: " + obj["Name"]);
                listBox1.Items.Add("Cores: " + obj["NumberOfCores"]);
            }
        }

        // 3. OS Info
        private void btnOS_Click(object sender, EventArgs e)
        {
            ClearList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                listBox1.Items.Add("OS: " + obj["Caption"]);
                listBox1.Items.Add("Version: " + obj["Version"]);
            }
        }

        // 4. Type
        private void btnType_Click(object sender, EventArgs e)
        {
            ClearList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                int role = Convert.ToInt32(obj["DomainRole"]);
                if (role == 0 || role == 1)
                    listBox1.Items.Add("Type: Workstation");
                else
                    listBox1.Items.Add("Type: Server");
            }
        }

        // 5. Memory
        private void btnMemory_Click(object sender, EventArgs e)
        {
            ClearList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PerfFormattedData_PerfOS_Memory");
            foreach (ManagementObject obj in searcher.Get())
            {
                listBox1.Items.Add("Available RAM: " + obj["AvailableMBytes"] + " MB");
            }
        }

        // 6. Services
        private void btnServices_Click(object sender, EventArgs e)
        {
            ClearList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Service WHERE State='Stopped'");
            foreach (ManagementObject obj in searcher.Get())
            {
                listBox1.Items.Add("Stopped: " + obj["DisplayName"]);
            }
        }

        // 7. Partitions
        private void btnPartitions_Click(object sender, EventArgs e)
        {
            ClearList();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            foreach (ManagementObject obj in searcher.Get())
            {
                double free = Convert.ToDouble(obj["FreeSpace"]) / (1024 * 1024 * 1024);
                listBox1.Items.Add(obj["Name"] + " Free: " + free.ToString("0.0") + " GB");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}