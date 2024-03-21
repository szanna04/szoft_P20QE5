using System.Windows.Forms;

namespace kigyos
{
    public partial class Form1 : Form
    {
        List<KígyóElem> kígyó_1 = new List<KígyóElem>();
        List<KígyóElem> kígyó_2 = new List<KígyóElem> ();

        public Form1()
        {
            InitializeComponent();
        }

        int fej1_x = 100;
        int fej1_y = 100;

        int fej2_x = 100;
        int fej2_y = 100;

        int irány1_x = 1;
        int irány1_y = 0;

        int irány2_x = 1;
        int irány2_y = 0;

        int lépésszám1;

        int lépésszám2;

        int hossz1 = 1;

        int hossz2 = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám1++;
            lépésszám2++;

            fej1_x += irány1_x * KígyóElem.Méret;
            fej1_y += irány1_y * KígyóElem.Méret;

            fej2_x += irány2_x * KígyóElem.Méret;
            fej2_y += irány2_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej1_y && k.Left == fej1_x && k.Top == fej2_y && k.Left == fej2_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            if (kígyó_1.Count > hossz1)
            {
                KígyóElem levágandó = kígyó_1[0];
                kígyó_1.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (kígyó_2.Count > hossz2)
            {
                KígyóElem levágandó = kígyó_2[0];
                kígyó_2.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fej1_y;
            ke.Left = fej1_x;
            Controls.Add(ke);

            KígyóElem ka = new KígyóElem();
            ka.Top = fej2_y;
            ka.Left = fej2_x;
            Controls.Add(ka);

            if (lépésszám1 % 2 == 0) ke.BackColor = Color.Yellow;

            if (lépésszám2 % 2 == 0) ka.BackColor = Color.Yellow;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány1_y = -1;
                irány1_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány1_y = 1;
                irány1_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány1_y = 0;
                irány1_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány1_y = 0;
                irány1_x = 1;
            }
            if (e.KeyCode == Keys.Up)
            {
                irány2_y = -1;
                irány2_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány2_y = 1;
                irány2_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány2_y = 0;
                irány2_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány2_y = 0;
                irány2_x = 1;
            }
        }
    }

}