﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Results_Box.Text = Results_Box.Text + button.Text;
        }
    }
}
