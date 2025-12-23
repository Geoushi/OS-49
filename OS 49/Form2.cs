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
        // اسم الملف اللي هنشتغل عليه
        string path = "exam_test.txt";

        public Form2()
        {
            InitializeComponent();
        }

        // 1. Write Text File
        private void btnWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, richTextBox1.Text);
            MessageBox.Show("File Created and Written Successfully!");
        }

        // 2. Read Text File
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                richTextBox1.Text = content;
                MessageBox.Show("File Read Successfully!");
            }
            else
            {
                MessageBox.Show("File not found! Write it first.");
            }
        }

        // 3. Append Text
        private void btnAppend_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(richTextBox1.Text);
            }
            MessageBox.Show("Text Appended Successfully!");
        }
    }
}
