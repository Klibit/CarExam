using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace CarExam
{
    public partial class FormOpen : Form
    {
        public FormOpen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string gyarto in Program.cars.Select(a => a.Marka).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = gyarto;
                cb.Checked = true;
                cb.Location = new Point(10, panelAutoMarkak.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(changed);
                panelAutoMarkak.Controls.Add(cb);
            }
            updateCarList();
        }

        private void changed(object sender, EventArgs e)
        {
            updateCarList();
        }

        private void updateCarList()
        {
            listBoxAutok.Items.Clear();
            List<string> list = new List<string>();
            foreach (CheckBox item in panelAutoMarkak.Controls)
            {
                if (item.Checked) list.Add(item.Text);
            }
            foreach (Car item in Program.cars)
            {
                if (list.Contains(item.Marka))
                {
                    listBoxAutok.Items.Add(item);
                }
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
