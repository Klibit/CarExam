namespace KonyvtarAsztali
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
            this.listBox1_Konyvek = new System.Windows.Forms.ListBox();
            this.button1_Load = new System.Windows.Forms.Button();
            this.button1_save = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1_Konyvek
            // 
            this.listBox1_Konyvek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1_Konyvek.FormattingEnabled = true;
            this.listBox1_Konyvek.ItemHeight = 16;
            this.listBox1_Konyvek.Location = new System.Drawing.Point(0, 0);
            this.listBox1_Konyvek.Name = "listBox1_Konyvek";
            this.listBox1_Konyvek.Size = new System.Drawing.Size(272, 450);
            this.listBox1_Konyvek.TabIndex = 0;
            // 
            // button1_Load
            // 
            this.button1_Load.Location = new System.Drawing.Point(391, 93);
            this.button1_Load.Name = "button1_Load";
            this.button1_Load.Size = new System.Drawing.Size(277, 74);
            this.button1_Load.TabIndex = 1;
            this.button1_Load.Text = "Betöltés";
            this.button1_Load.UseVisualStyleBackColor = true;
            // 
            // button1_save
            // 
            this.button1_save.Location = new System.Drawing.Point(278, 245);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(236, 38);
            this.button1_save.TabIndex = 2;
            this.button1_save.Text = "Mentés";
            this.button1_save.UseVisualStyleBackColor = true;
            this.button1_save.Click += new System.EventHandler(this.button1_save_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(539, 245);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(236, 38);
            this.button_insert.TabIndex = 2;
            this.button_insert.Text = "Új";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(278, 316);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(236, 38);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Módosítás";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(539, 316);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(236, 38);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.button1_Load);
            this.Controls.Add(this.listBox1_Konyvek);
            this.Name = "Form1";
            this.Text = "Könyvtár nyilvántartás";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1_Load;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.ListBox listBox1_Konyvek;
    }
}

