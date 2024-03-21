using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyos
{
    internal class Mérgek : PictureBox
    {
        public static int MMéret = 20;

        public Mérgek()
        {
            Width = Mérgek.MMéret;
            Height = Mérgek.MMéret;
            BackColor = Color.Red;
        }
    }
}
