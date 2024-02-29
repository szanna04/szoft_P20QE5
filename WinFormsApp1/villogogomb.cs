using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikhet
{
    internal class villogogomb:Button
    {
        public villogogomb()
        {
        MouseEnter = villogogomb.MouseButtons;
        }
    private void villogogomb_MouseEnter(object sender, EventArgs e) 
        {
        BackColor = Color.Fuchsia;
        }
    }
}
