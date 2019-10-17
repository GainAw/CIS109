using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class MazeGame_Form : Form
    {
        private int Points = 3000;
        private int Seconds = 30;
        System.Media.SoundPlayer StartSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring10.wav");
        System.Media.SoundPlayer RestartSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Speech Off.wav");
        System.Media.SoundPlayer FinishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        public MazeGame_Form()
        {
            StartSoundPlayer.Play();
            InitializeComponent();
            MoveToStart();
            Point_Counter.Text = Points.ToString();
            Game_Timer.Text = Seconds.ToString();
        }

        private void Finish_Label_MouseEnter(object sender, EventArgs e)
        {
            GameTimer.Stop();
            FinishSoundPlayer.Play();
            MessageBox.Show("Congrats You Won. Your Score is " + Points);
            Close();
        }

        private void MoveToStart()
        {
            Point Starting_Point = Game_Area.Location;
            Starting_Point.Offset(10,10);
            Cursor.Position = PointToScreen(Starting_Point);
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            RestartSoundPlayer.Play();
            MoveToStart();
        }

        private void GameTimerTimeOut(object sender, EventArgs e)
        {
            Seconds -= 1;
            Points -= 100;
            Point_Counter.Text = Points.ToString();
            Game_Timer.Text = Seconds.ToString();
            if (Seconds == 0)
            {
                GameTimer.Stop();
                MessageBox.Show("You have lost");
                Seconds = 30;
                Points = 3000;
                MoveToStart();
            }
            GameTimer.Start();
        }
    }
}
