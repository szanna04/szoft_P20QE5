namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            Button b = new Button();
            b.Left = ClickRectangle Height / 2 - b.Height;
            b.Top = ClickRectangle Height / 2 - b.Height;


            int matrix = 20;
            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    villogogomb p = new Button();
                    Console.Add(p);
                    p.Height = matrix;
                    p.Width = matrix;
                    p.left = matrix * oszlop;
                    p.top = matrix * sor;



                }
            }
        }
    }
}