namespace Mozzarella_Sticks
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Back_Button = new System.Windows.Forms.ToolStripButton();
            this.Forward_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Search_Bar = new System.Windows.Forms.ToolStripComboBox();
            this.Go_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back_Button,
            this.Forward_Button,
            this.toolStripSeparator1,
            this.Search_Bar,
            this.Go_Button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 0;
            // 
            // Back_Button
            // 
            this.Back_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(36, 22);
            this.Back_Button.Text = "Back";
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Forward_Button
            // 
            this.Forward_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Forward_Button.Image = ((System.Drawing.Image)(resources.GetObject("Forward_Button.Image")));
            this.Forward_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(54, 22);
            this.Forward_Button.Text = "Forward";
            this.Forward_Button.Click += new System.EventHandler(this.Forward_Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Search_Bar
            // 
            this.Search_Bar.Name = "Search_Bar";
            this.Search_Bar.Size = new System.Drawing.Size(121, 25);
            this.Search_Bar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Bar_KeyDown);
            // 
            // Go_Button
            // 
            this.Go_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Go_Button.Image = ((System.Drawing.Image)(resources.GetObject("Go_Button.Image")));
            this.Go_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Go_Button.Name = "Go_Button";
            this.Go_Button.Size = new System.Drawing.Size(26, 22);
            this.Go_Button.Text = "Go";
            this.Go_Button.Click += new System.EventHandler(this.Go_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main_Form";
            this.Text = "Mozzarella Sticks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton Back_Button;
        private System.Windows.Forms.ToolStripButton Forward_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox Search_Bar;
        private System.Windows.Forms.ToolStripButton Go_Button;
    }
}

