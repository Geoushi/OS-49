namespace OS_49
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(101, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(551, 204);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Basic Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBasicInfo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(158, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "CPU Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCPU_Click;
            // 
            // button3
            // 
            button3.Location = new Point(292, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "OS Info";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnOS_Click;
            // 
            // button4
            // 
            button4.Location = new Point(419, 12);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Computer Type";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnType_Click;
            // 
            // button5
            // 
            button5.Location = new Point(570, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "Memory";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnMemory_Click;
            // 
            // button6
            // 
            button6.Location = new Point(133, 73);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "Services";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnServices_Click;
            // 
            // button7
            // 
            button7.Location = new Point(488, 73);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 8;
            button7.Text = "Partitions";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnPartitions_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}