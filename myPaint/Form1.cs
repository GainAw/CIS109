﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPaint
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseToggle(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox1.Image = bmp;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void ToolStripButton7_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }
    }
}
