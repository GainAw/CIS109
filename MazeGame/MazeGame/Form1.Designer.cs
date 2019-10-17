namespace MazeGame
{
    partial class MazeGame_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Game_Area = new System.Windows.Forms.Panel();
            this.Point_Counter = new System.Windows.Forms.Label();
            this.Game_Timer = new System.Windows.Forms.Label();
            this.Finish_Label = new System.Windows.Forms.Label();
            this.Wall5 = new System.Windows.Forms.Label();
            this.Wall4 = new System.Windows.Forms.Label();
            this.Wall3 = new System.Windows.Forms.Label();
            this.Wall6 = new System.Windows.Forms.Label();
            this.Wall2 = new System.Windows.Forms.Label();
            this.Wall7 = new System.Windows.Forms.Label();
            this.Wall1 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Game_Area.SuspendLayout();
            this.SuspendLayout();
            // 
            // Game_Area
            // 
            this.Game_Area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Game_Area.Controls.Add(this.Point_Counter);
            this.Game_Area.Controls.Add(this.Game_Timer);
            this.Game_Area.Controls.Add(this.Finish_Label);
            this.Game_Area.Controls.Add(this.Wall5);
            this.Game_Area.Controls.Add(this.Wall4);
            this.Game_Area.Controls.Add(this.Wall3);
            this.Game_Area.Controls.Add(this.Wall6);
            this.Game_Area.Controls.Add(this.Wall2);
            this.Game_Area.Controls.Add(this.Wall7);
            this.Game_Area.Controls.Add(this.Wall1);
            this.Game_Area.Location = new System.Drawing.Point(12, 12);
            this.Game_Area.Name = "Game_Area";
            this.Game_Area.Size = new System.Drawing.Size(610, 587);
            this.Game_Area.TabIndex = 0;
            // 
            // Point_Counter
            // 
            this.Point_Counter.AutoSize = true;
            this.Point_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Point_Counter.Location = new System.Drawing.Point(264, 192);
            this.Point_Counter.Name = "Point_Counter";
            this.Point_Counter.Size = new System.Drawing.Size(58, 26);
            this.Point_Counter.TabIndex = 9;
            this.Point_Counter.Text = "Start";
            this.Point_Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game_Timer
            // 
            this.Game_Timer.AutoSize = true;
            this.Game_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Game_Timer.Location = new System.Drawing.Point(120, 192);
            this.Game_Timer.Name = "Game_Timer";
            this.Game_Timer.Size = new System.Drawing.Size(58, 26);
            this.Game_Timer.TabIndex = 8;
            this.Game_Timer.Text = "Start";
            this.Game_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Finish_Label
            // 
            this.Finish_Label.AutoSize = true;
            this.Finish_Label.Location = new System.Drawing.Point(544, 532);
            this.Finish_Label.Name = "Finish_Label";
            this.Finish_Label.Size = new System.Drawing.Size(34, 13);
            this.Finish_Label.TabIndex = 7;
            this.Finish_Label.Text = "Finish";
            this.Finish_Label.MouseEnter += new System.EventHandler(this.Finish_Label_MouseEnter);
            // 
            // Wall5
            // 
            this.Wall5.BackColor = System.Drawing.Color.DarkKhaki;
            this.Wall5.Location = new System.Drawing.Point(460, 560);
            this.Wall5.Name = "Wall5";
            this.Wall5.Size = new System.Drawing.Size(129, 23);
            this.Wall5.TabIndex = 6;
            this.Wall5.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.Color.DarkKhaki;
            this.Wall4.Location = new System.Drawing.Point(585, 513);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(23, 72);
            this.Wall4.TabIndex = 5;
            this.Wall4.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // Wall3
            // 
            this.Wall3.BackColor = System.Drawing.Color.DarkKhaki;
            this.Wall3.Location = new System.Drawing.Point(520, 490);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(88, 23);
            this.Wall3.TabIndex = 4;
            this.Wall3.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // Wall6
            // 
            this.Wall6.BackColor = System.Drawing.Color.DarkKhaki;
            this.Wall6.Location = new System.Drawing.Point(442, 76);
            this.Wall6.Name = "Wall6";
            this.Wall6.Size = new System.Drawing.Size(23, 509);
            this.Wall6.TabIndex = 3;
            this.Wall6.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.DarkKhaki;
            this.Wall2.Location = new System.Drawing.Point(500, 23);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(23, 490);
            this.Wall2.TabIndex = 2;
            this.Wall2.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // Wall7
            // 
            this.Wall7.BackColor = System.Drawing.Color.DarkKhaki;
            this.Wall7.Location = new System.Drawing.Point(-2, 53);
            this.Wall7.Name = "Wall7";
            this.Wall7.Size = new System.Drawing.Size(467, 23);
            this.Wall7.TabIndex = 1;
            this.Wall7.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.Color.DarkKhaki;
            this.Wall1.Location = new System.Drawing.Point(52, 0);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(471, 23);
            this.Wall1.TabIndex = 0;
            this.Wall1.MouseEnter += new System.EventHandler(this.Wall_MouseEnter);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerTimeOut);
            // 
            // MazeGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.Game_Area);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MazeGame_Form";
            this.Text = "Maze Game";
            this.Game_Area.ResumeLayout(false);
            this.Game_Area.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Game_Area;
        private System.Windows.Forms.Label Wall7;
        private System.Windows.Forms.Label Wall1;
        private System.Windows.Forms.Label Wall3;
        private System.Windows.Forms.Label Wall6;
        private System.Windows.Forms.Label Wall2;
        private System.Windows.Forms.Label Wall5;
        private System.Windows.Forms.Label Wall4;
        private System.Windows.Forms.Label Finish_Label;
        private System.Windows.Forms.Label Point_Counter;
        private System.Windows.Forms.Label Game_Timer;
        public System.Windows.Forms.Timer GameTimer;
    }
}

