namespace CurrencyConverter
{
    partial class CurrencyConverter
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
            this.ButtonConverter = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ButtonConverter
            // 
            this.ButtonConverter.BackColor = System.Drawing.Color.DarkSalmon;
            this.ButtonConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ButtonConverter.Location = new System.Drawing.Point(12, 12);
            this.ButtonConverter.Name = "ButtonConverter";
            this.ButtonConverter.Size = new System.Drawing.Size(776, 42);
            this.ButtonConverter.TabIndex = 0;
            this.ButtonConverter.Text = "Currency Converter";
            this.ButtonConverter.UseVisualStyleBackColor = false;
            this.ButtonConverter.Click += new System.EventHandler(this.ButtonConverter_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 60);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 378);
            this.webBrowser1.TabIndex = 1;
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.ButtonConverter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Currency Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonConverter;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

