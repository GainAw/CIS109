using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {

        }

        private void SetBGColor_Button_Click(object sender, EventArgs e)
        {

        }

        private void ClearPicture_Button_Click(object sender, EventArgs e)
        {

        }

        private void ShowPicture_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Stretched_Bool_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
