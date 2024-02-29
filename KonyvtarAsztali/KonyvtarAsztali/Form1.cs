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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("insert");
            form2.ShowDialog();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            
            if(listBox1_Konyvek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs könyv kiválasztva");
                return;
            }
            Konyv konyv = (Konyv)listBox1_Konyvek.SelectedItem;
            listBox1_Konyvek.Items.Remove(konyv);
            Form2 form2 = new Form2("update", konyv);
            form2.ShowDialog();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox1_Konyvek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincsen könyv kiválasztva");
                return;
            }
            Konyv konyv = (Konyv)listBox1_Konyvek.SelectedItem;
            listBox1_Konyvek.Items.Remove(konyv);

        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            
        }
    }
}
