namespace OS_49
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void file_man_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // بنعمل نسخة من فورم الملفات
            f2.ShowDialog();        // بنفتحها
        }

        private void sys_info_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // بنعمل نسخة من فورم السيستم
            f3.ShowDialog();        // بنفتحها
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
