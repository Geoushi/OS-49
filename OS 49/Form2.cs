using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OS_49
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // زرار الكتابة (Write)
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("Please enter a file name!");
                return;
            }
            File.WriteAllText(txtPath.Text, richTextBox1.Text);
            MessageBox.Show("File created successfully");
        }

        // زرار القراءة (Read)
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPath.Text))
            {
                richTextBox1.Text = File.ReadAllText(txtPath.Text);
                MessageBox.Show("Opened file: " + txtPath.Text);
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        // زرار الإضافة (Append)
        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPath.Text))
            {
                File.AppendAllText(txtPath.Text, "\n" + richTextBox1.Text);
                MessageBox.Show("Text appended successfully");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }
    }
}
