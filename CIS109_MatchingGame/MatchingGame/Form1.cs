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

        Label First_Clicked, Second_Clicked;

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

                    icon_label.ForeColor = icon_label.BackColor;
                    icons.RemoveAt(random_number);
                }

            }


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            First_Clicked.ForeColor = First_Clicked.BackColor;
            Second_Clicked.ForeColor = Second_Clicked.BackColor;

            First_Clicked = null;
            Second_Clicked = null;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (First_Clicked != null && Second_Clicked != null)
            {
                return;
            }

            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
            {
                return;
            }

            if (clickedLabel.ForeColor == Color.Black)
            {
                return;
            }

            if (First_Clicked == null)
            {
                First_Clicked = clickedLabel;
                First_Clicked.ForeColor = Color.Black;
                return;
            }

            Second_Clicked = clickedLabel;
            Second_Clicked.ForeColor = Color.Black;

            Check_For_Winner();

            if (First_Clicked.Text == Second_Clicked.Text)
            {
                First_Clicked = null;
                Second_Clicked = null;
            }
            else
            {
                timer1.Start();
            }
        }
        private void Check_For_Winner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                {
                    return;
                }
            }
            MessageBox.Show("You won congrats");
            Close();
        }
    }
}
