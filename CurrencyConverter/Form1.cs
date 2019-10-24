using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void ButtonConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?safe=strict&sxsrf=ACYBGNSQ334O8vZBuqHzU960NvGeEGd4VA%3A1571885278146&ei=3hCxXbvGCJeU0PEP4LyZwAY&q=google+currency+converter&oq=currency+converter&gs_l=psy-ab.1.2.0i71l8.0.0..3955...0.2..0.0.0.......0......gws-wiz.VB3y5HSK2kM");
        }
    }
}
