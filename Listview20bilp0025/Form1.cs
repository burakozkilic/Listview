using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview20bilp0025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Kayıt No", 60);
            listView1.Columns.Add("Ad Soyad", 150);
            listView1.Columns.Add("Telefon No", 100);
            listView1.Columns.Add("Adres", 300);

        }
        int kayit_id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            kayit_id++;
            string[] row = { kayit_id.ToString(), textBox1.Text, textBox2.Text, textBox3.Text };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
