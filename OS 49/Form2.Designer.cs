namespace OS_49
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            btnWrite = new Button();
            btnRead = new Button();
            btnAppend = new Button();
            txtPath = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 128);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 295);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(125, 26);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(110, 41);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(337, 26);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 41);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnAppend
            // 
            btnAppend.Location = new Point(565, 26);
            btnAppend.Name = "btnAppend";
            btnAppend.Size = new Size(94, 41);
            btnAppend.TabIndex = 3;
            btnAppend.Text = "Append Text";
            btnAppend.UseVisualStyleBackColor = true;
            btnAppend.Click += btnAppend_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(97, 85);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(691, 27);
            txtPath.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 6;
            label1.Text = "File Name:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtPath);
            Controls.Add(btnAppend);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(richTextBox1);
            Name = "Form2";
            Text = "File Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnWrite;
        private Button btnRead;
        private Button btnAppend;
        private TextBox txtPath;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
    }
}