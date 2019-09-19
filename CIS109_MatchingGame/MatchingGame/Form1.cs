/* Wesley Crank
Reno Techknology Academy
CIS109: Coding in c3 for imbedded Systems
Udemy: 17 Begining c# walkthrough Projects Step by Step
Project 1: Create a Matching pairs icon image Game
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form_Matching_Game : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", ".", ".", "T", "T", "W", "W",
            "k", "k", "|", "|", "@", "@", "%", "%"
        };
        public Form_Matching_Game()
        {
            InitializeComponent();
            AssignIcontoSquares();
        }

        private void AssignIcontoSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label icon_label = control as Label;
                if (icon_label != null)
                {
                    int random_number = random.Next(icons.Count);
                    icon_label.Text = icons[random_number];

                    //icon_label.ForeColor = icon_label.BackColor;
                    icons.RemoveAt(random_number);
                }

            }


        }
    }
}
