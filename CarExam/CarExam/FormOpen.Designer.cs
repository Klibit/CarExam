namespace CarExam
{
    partial class FormOpen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxAutok = new System.Windows.Forms.ListBox();
            this.panelAutoMarkak = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autókToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autókToolStripMenuItem
            // 
            this.autókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosToolStripMenuItem,
            this.törölToolStripMenuItem});
            this.autókToolStripMenuItem.Name = "autókToolStripMenuItem";
            this.autókToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.autókToolStripMenuItem.Text = "Autók";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // módosToolStripMenuItem
            // 
            this.módosToolStripMenuItem.Name = "módosToolStripMenuItem";
            this.módosToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.módosToolStripMenuItem.Text = "Módosít";
            this.módosToolStripMenuItem.Click += new System.EventHandler(this.módosToolStripMenuItem_Click);
            // 
            // törölToolStripMenuItem
            // 
            this.törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            this.törölToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.törölToolStripMenuItem.Text = "Töröl";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(682, 209);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 1;
            // 
            // listBoxAutok
            // 
            this.listBoxAutok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxAutok.FormattingEnabled = true;
            this.listBoxAutok.ItemHeight = 16;
            this.listBoxAutok.Location = new System.Drawing.Point(0, 28);
            this.listBoxAutok.Name = "listBoxAutok";
            this.listBoxAutok.Size = new System.Drawing.Size(417, 422);
            this.listBoxAutok.TabIndex = 2;
            this.listBoxAutok.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // panelAutoMarkak
            // 
            this.panelAutoMarkak.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAutoMarkak.Location = new System.Drawing.Point(417, 28);
            this.panelAutoMarkak.Name = "panelAutoMarkak";
            this.panelAutoMarkak.Size = new System.Drawing.Size(200, 422);
            this.panelAutoMarkak.TabIndex = 3;
            // 
            // FormOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAutoMarkak);
            this.Controls.Add(this.listBoxAutok);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOpen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxAutok;
        private System.Windows.Forms.Panel panelAutoMarkak;
    }
}

