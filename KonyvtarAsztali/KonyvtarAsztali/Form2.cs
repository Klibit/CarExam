using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarAsztali
{
    public partial class Form2 : Form
    {
        string muvelet;

        public Form2(string muvelet, Object parameter = null)
        {
            InitializeComponent();
            this.muvelet = muvelet;
            switch (muvelet)
            {
                case "insert":
                    button1.Text = "Mentés";
                    this.Text = "Új adatok:";
                    break;
                case "update":
                    button1.Text = "Módosít";
                    this.Text = "Adatok módosítása";
                    Konyv konyv = (Konyv)parameter;
                   //  Konyv konyv = (Konyv)Program.baseForm.listBox1_Konyvek.SelectedItem;
                    textBox_Id.Text=konyv.Id.ToString();
                    textBox_Author.Text= konyv.Author.ToString();
                    numericUpDown1_Pagecount.Value = konyv.Page_count;
                    numericUpDown_PublishDate.Value = konyv.Publish_year;
                    textBox_Title.Text= konyv.Title.ToString();

                     break;
                default:
                    break;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch(muvelet)
            {
                case "insert":
                    UjKonyv();
                    break;
                case "update":
                    modosit();
                    break;
            }

        }


        private void UjKonyv()
        {
            int id = Program.baseForm.listBox1_Konyvek.Items.Count + 1;
            string author = textBox_Author.Text;
            int page_count = (int)numericUpDown1_Pagecount.Value;
            int publish_year = (int)numericUpDown_PublishDate.Value;
            string title = textBox_Title.Text;
            Konyv ujKony = new Konyv(id, author, publish_year, page_count, title);
            Program.db.insertKonyv(id, author,page_count,publish_year,title);
            Program.baseForm.listBox1_Konyvek.Items.Add(ujKony);
            this.Close();
        }

        private void modosit()
        {
            int id = int.Parse(textBox_Id.Text);
            string author = textBox_Author.Text;
            int page_count = (int)numericUpDown1_Pagecount.Value;
            int publish_year = (int)numericUpDown_PublishDate.Value;
            string title = textBox_Title.Text;
            Konyv ujKony = new Konyv(id, author, publish_year, page_count, title);
            Program.db.updateKonyv(id, author, page_count, publish_year, title);
            Program.baseForm.listBox1_Konyvek.Items.Add(ujKony);
            this.Close();

        }
    }
}
