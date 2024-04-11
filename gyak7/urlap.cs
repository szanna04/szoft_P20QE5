using CsvHelper;
using gyak7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak7
{
    public partial class urlap : Form
    {
        public CountryData CountryData;
        public urlap()
        {
            InitializeComponent();
        }

        private void urlap_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

    }
}