using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikhet
{
    internal class szamologomb : VillogoGomb
    {
        public szamologomb()
        {
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
