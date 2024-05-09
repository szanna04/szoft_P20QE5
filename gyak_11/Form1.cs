namespace gyak11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new UserControl1();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // panel1.Controls.Add(new UserControl2() {Dock = DockStyle.Fill});
            panel1.Controls.Clear();
            UserControl userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }
    }
}