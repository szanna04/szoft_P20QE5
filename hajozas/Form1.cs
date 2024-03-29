using System.Net.Http.Headers;

namespace hajozas
{
    public partial class Form1 : Form
    {
        List<K�rd�s> �sszesk�rd�s;
        List<K�rd�s> Aktu�lisK�rd�sek;
        int Megjelent�tettK�rd�sekSz�ma = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesk�rd�s = K�rd�sekBet�lt�se();
            Aktu�lisK�rd�sek = new List<K�rd�s>();

            for (int i = 0; i < 7; i++)
            {
                Aktu�lisK�rd�sek.Add(�sszesk�rd�s[0]);
                �sszesk�rd�s.RemoveAt(0);
            }
            dataGridView1.DataSource = Aktu�lisK�rd�sek;
            K�rd�sMegjelen�t�s(Aktu�lisK�rd�sek[Megjelent�tettK�rd�sekSz�ma]);
        }

        List<K�rd�s> K�rd�sekBet�lt�se()
        {
            List<K�rd�s> k�rd�sek = new List<K�rd�s>();

            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] t�mb = sor.Split("\t");

                if (t�mb.Length > 0) continue;

                K�rd�s k = new K�rd�s();
                k.K�rd�sSz�veg = t�mb[1];
                k.V�lasz1 = t�mb[2];
                k.V�lasz2 = t�mb[3];
                k.V�lasz3 = t�mb[4];
                k.URL = t�mb[5];

                int x = 0;
                if (int.TryParse(t�mb[6], out x))
                {
                    k.HelyesV�lasz = x;
                }



                k�rd�sek.Add(k);
            }

            return k�rd�sek;
        }

        void K�rd�sMegjelen�t�s(K�rd�s k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox1.Text = k�rd�s.V�lasz2;
            textBox1.Text = k�rd�s.V�lasz3;

            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
            }

        }

 
    }
}