namespace OS_49
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            file_man = new Button();
            sys_info = new Button();
            SuspendLayout();
            // 
            // file_man
            // 
            file_man.Location = new Point(298, 170);
            file_man.Name = "file_man";
            file_man.Size = new Size(179, 49);
            file_man.TabIndex = 0;
            file_man.Text = "File Manager";
            file_man.UseVisualStyleBackColor = true;
            // 
            // sys_info
            // 
            sys_info.Location = new Point(298, 281);
            sys_info.Name = "sys_info";
            sys_info.Size = new Size(179, 50);
            sys_info.TabIndex = 1;
            sys_info.Text = "System Info";
            sys_info.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 543);
            Controls.Add(sys_info);
            Controls.Add(file_man);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button file_man;
        private Button sys_info;
    }
}
