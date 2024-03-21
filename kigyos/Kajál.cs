using kigyos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyos
{        
    internal class Kajál : PictureBox
    {
        public static int KMéret = 20;

        public Kajál()
        {
            Width = Kajál.KMéret;
            Height = Kajál.KMéret;
            BackColor = Color.Green;
        }
    }
}
