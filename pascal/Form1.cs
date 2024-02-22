namespace pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Faktori�lis(int n)
        {
            int eredm�ny = 1;
            for (int i = 1; i <= n; i++) eredm�ny *= i;

            return eredm�ny;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Button b = new Button();
                    Controls.Add(b);
                    b.Top = sor * n;
                    b.Left = oszlop * n - sor * n/2;
                    b.Height = n;
                    b.Width = n;
                    int x = Faktori�lis(sor) / (Faktori�lis(oszlop) * Faktori�lis(sor-oszlop));
                    b.Text = x.ToString();
                }
            }
        }
    }
}