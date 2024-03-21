using System.Windows.Forms;

namespace kigyos
{
    public partial class Form1 : Form
    {
        List<K�gy�Elem> k�gy�_1 = new List<K�gy�Elem>();
        List<K�gy�Elem> k�gy�_2 = new List<K�gy�Elem> ();

        public Form1()
        {
            InitializeComponent();
        }

        int fej1_x = 100;
        int fej1_y = 100;

        int fej2_x = 100;
        int fej2_y = 100;

        int ir�ny1_x = 1;
        int ir�ny1_y = 0;

        int ir�ny2_x = 1;
        int ir�ny2_y = 0;

        int l�p�ssz�m1;

        int l�p�ssz�m2;

        int hossz1 = 1;

        int hossz2 = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m1++;
            l�p�ssz�m2++;

            fej1_x += ir�ny1_x * K�gy�Elem.M�ret;
            fej1_y += ir�ny1_y * K�gy�Elem.M�ret;

            fej2_x += ir�ny2_x * K�gy�Elem.M�ret;
            fej2_y += ir�ny2_y * K�gy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej1_y && k.Left == fej1_x && k.Top == fej2_y && k.Left == fej2_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            if (k�gy�_1.Count > hossz1)
            {
                K�gy�Elem lev�gand� = k�gy�_1[0];
                k�gy�_1.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (k�gy�_2.Count > hossz2)
            {
                K�gy�Elem lev�gand� = k�gy�_2[0];
                k�gy�_2.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej1_y;
            ke.Left = fej1_x;
            Controls.Add(ke);

            K�gy�Elem ka = new K�gy�Elem();
            ka.Top = fej2_y;
            ka.Left = fej2_x;
            Controls.Add(ka);

            if (l�p�ssz�m1 % 2 == 0) ke.BackColor = Color.Yellow;

            if (l�p�ssz�m2 % 2 == 0) ka.BackColor = Color.Yellow;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny1_y = -1;
                ir�ny1_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny1_y = 1;
                ir�ny1_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny1_y = 0;
                ir�ny1_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny1_y = 0;
                ir�ny1_x = 1;
            }
            if (e.KeyCode == Keys.Up)
            {
                ir�ny2_y = -1;
                ir�ny2_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny2_y = 1;
                ir�ny2_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny2_y = 0;
                ir�ny2_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny2_y = 0;
                ir�ny2_x = 1;
            }
        }
    }

}