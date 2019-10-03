namespace MyMusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Play_Button = new System.Windows.Forms.Button();
            this.Pause_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-1, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(683, 199);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-1, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 30);
            this.textBox1.TabIndex = 1;
            // 
            // Browse_Button
            // 
            this.Browse_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.Browse_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Browse_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse_Button.ForeColor = System.Drawing.Color.White;
            this.Browse_Button.Location = new System.Drawing.Point(10, 208);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(115, 41);
            this.Browse_Button.TabIndex = 2;
            this.Browse_Button.Text = "Browse";
            this.Browse_Button.UseVisualStyleBackColor = false;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Play_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Button.ForeColor = System.Drawing.Color.White;
            this.Play_Button.Location = new System.Drawing.Point(131, 208);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(115, 41);
            this.Play_Button.TabIndex = 3;
            this.Play_Button.Text = "Play";
            this.Play_Button.UseVisualStyleBackColor = false;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // Pause_Button
            // 
            this.Pause_Button.BackColor = System.Drawing.Color.DarkGreen;
            this.Pause_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_Button.ForeColor = System.Drawing.Color.White;
            this.Pause_Button.Location = new System.Drawing.Point(252, 208);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(115, 41);
            this.Pause_Button.TabIndex = 4;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = false;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackColor = System.Drawing.Color.HotPink;
            this.Stop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.ForeColor = System.Drawing.Color.White;
            this.Stop_Button.Location = new System.Drawing.Point(373, 208);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(115, 41);
            this.Stop_Button.TabIndex = 5;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = false;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.DarkOrchid;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.Location = new System.Drawing.Point(554, 208);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(115, 41);
            this.Exit_Button.TabIndex = 6;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(681, 258);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Button Pause_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

