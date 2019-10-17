namespace PictureViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Stretched_Bool = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SetBGColor_Button = new System.Windows.Forms.Button();
            this.ClearPicture_Button = new System.Windows.Forms.Button();
            this.ShowPicture_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Stretched_Bool, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 282);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Stretched_Bool
            // 
            this.Stretched_Bool.AutoSize = true;
            this.Stretched_Bool.Location = new System.Drawing.Point(3, 291);
            this.Stretched_Bool.Name = "Stretched_Bool";
            this.Stretched_Bool.Size = new System.Drawing.Size(72, 17);
            this.Stretched_Bool.TabIndex = 1;
            this.Stretched_Bool.Text = "Stretched";
            this.Stretched_Bool.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Close_Button);
            this.flowLayoutPanel1.Controls.Add(this.SetBGColor_Button);
            this.flowLayoutPanel1.Controls.Add(this.ClearPicture_Button);
            this.flowLayoutPanel1.Controls.Add(this.ShowPicture_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(84, 291);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 27);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Close_Button
            // 
            this.Close_Button.AutoSize = true;
            this.Close_Button.Location = new System.Drawing.Point(3, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 23);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            // 
            // SetBGColor_Button
            // 
            this.SetBGColor_Button.AutoSize = true;
            this.SetBGColor_Button.Location = new System.Drawing.Point(84, 3);
            this.SetBGColor_Button.Name = "SetBGColor_Button";
            this.SetBGColor_Button.Size = new System.Drawing.Size(121, 23);
            this.SetBGColor_Button.TabIndex = 1;
            this.SetBGColor_Button.Text = "Set Background Color";
            this.SetBGColor_Button.UseVisualStyleBackColor = true;
            // 
            // ClearPicture_Button
            // 
            this.ClearPicture_Button.AutoSize = true;
            this.ClearPicture_Button.Location = new System.Drawing.Point(211, 3);
            this.ClearPicture_Button.Name = "ClearPicture_Button";
            this.ClearPicture_Button.Size = new System.Drawing.Size(77, 23);
            this.ClearPicture_Button.TabIndex = 2;
            this.ClearPicture_Button.Text = "Clear Picture";
            this.ClearPicture_Button.UseVisualStyleBackColor = true;
            // 
            // ShowPicture_Button
            // 
            this.ShowPicture_Button.AutoSize = true;
            this.ShowPicture_Button.Location = new System.Drawing.Point(294, 3);
            this.ShowPicture_Button.Name = "ShowPicture_Button";
            this.ShowPicture_Button.Size = new System.Drawing.Size(80, 23);
            this.ShowPicture_Button.TabIndex = 3;
            this.ShowPicture_Button.Text = "Show Picture";
            this.ShowPicture_Button.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|Bmp Files (*.bmp)|*All files (*." +
    "*)|*.*|";
            this.openFileDialog1.Title = "Select a picture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox Stretched_Bool;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button SetBGColor_Button;
        private System.Windows.Forms.Button ClearPicture_Button;
        private System.Windows.Forms.Button ShowPicture_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

