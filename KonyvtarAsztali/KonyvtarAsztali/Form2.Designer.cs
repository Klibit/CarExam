using System;

namespace KonyvtarAsztali
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.numericUpDown1_Pagecount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PublishDate = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Pagecount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PublishDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(209, 39);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(268, 22);
            this.textBox_Id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Szerző";
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(209, 79);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(268, 22);
            this.textBox_Author.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oldalszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kiadás éve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cím";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(209, 214);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(268, 22);
            this.textBox_Title.TabIndex = 1;
            // 
            // numericUpDown1_Pagecount
            // 
            this.numericUpDown1_Pagecount.Location = new System.Drawing.Point(209, 126);
            this.numericUpDown1_Pagecount.Name = "numericUpDown1_Pagecount";
            this.numericUpDown1_Pagecount.Size = new System.Drawing.Size(268, 22);
            this.numericUpDown1_Pagecount.TabIndex = 3;
           // this.numericUpDown1_Pagecount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown_PublishDate
            // 
            this.numericUpDown_PublishDate.Location = new System.Drawing.Point(209, 171);
            this.numericUpDown_PublishDate.Name = "numericUpDown_PublishDate";
            this.numericUpDown_PublishDate.Size = new System.Drawing.Size(268, 22);
            this.numericUpDown_PublishDate.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 84);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_PublishDate);
            this.Controls.Add(this.numericUpDown1_Pagecount);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Könyvek";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Pagecount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PublishDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Pagecount;
        private System.Windows.Forms.NumericUpDown numericUpDown_PublishDate;
        private System.Windows.Forms.Button button1;
    }
}