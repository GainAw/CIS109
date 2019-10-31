using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mozzarella_Sticks
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Search_Bar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(Search_Bar.Text);
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Forward_Button_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Go_Button_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Search_Bar.Text);
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "Mozzarella Sticks - " + webBrowser1.Document.Title;
        }
    }
}
