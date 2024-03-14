using System.Net.Http.Headers;

namespace hajozas
{
    public partial class Form1 : Form
    {
        List<Kérdés> Összeskérdés;
        List<Kérdés> AktuálisKérdések;
        int MegjelentítettKérdésekSzáma = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Összeskérdés = KérdésekBetöltése();
            AktuálisKérdések = new List<Kérdés>();

            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(Összeskérdés[0]);
                Összeskérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktuálisKérdések;
            KérdésMegjelenítés(AktuálisKérdések[MegjelentítettKérdésekSzáma]);
        }

        List<Kérdés> KérdésekBetöltése()
        {
            List<Kérdés> kérdések = new List<Kérdés>();

            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");

                if (tömb.Length > 0) continue;

                Kérdés k = new Kérdés();
                k.KérdésSzöveg = tömb[1];
                k.Válasz1 = tömb[2];
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int x = 0;
                if (int.TryParse(tömb[6], out x))
                {
                    k.HelyesVálasz = x;
                }



                kérdések.Add(k);
            }

            return kérdések;
        }

        void KérdésMegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox1.Text = kérdés.Válasz2;
            textBox1.Text = kérdés.Válasz3;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }

        }

 
    }
}