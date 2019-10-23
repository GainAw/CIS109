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
            //closes aplication
            this.Close();
        }

        private void SetBGColor_Button_Click(object sender, EventArgs e)
        {
            //open color dialog
            //sets background color to selected color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void ClearPicture_Button_Click(object sender, EventArgs e)
        {
            //clears the picture
            pictureBox1.Image = null;
        }

        private void ShowPicture_Button_Click(object sender, EventArgs e)
        {
            //shows the open file dialog
            //then load selected photo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void Stretched_Bool_CheckedChanged(object sender, EventArgs e)
        {
            //If the check is checked
            //stretch or unstrech the image
            if (Stretched_Bool.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
