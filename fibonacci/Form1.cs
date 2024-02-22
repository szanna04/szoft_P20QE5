using System.Net.Http.Headers;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<sor> sorok = new List<sor>();

            for (int i = 0; i < 10; i++)
            {
                sor �jSor = new sor();
                �jSor.Ertek = Fibonacci(i);
                �jSor.Sorszam = i;

                sorok.Add(�jSor);
            }

            dataGridView1.DataSource = sorok;
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}