using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kayıtlar> Kayıt = new List<Kayıtlar>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayıtlar ögrenci = new Kayıtlar();
            ögrenci.Ad = txtAd.Text;
            ögrenci.Soyad = txtSoyad.Text;
            ögrenci.Numara = txtNo.Text;

            Kayıt.Add(ögrenci);
            txtAd.Text = null;
            txtNo.Text = null;
            txtSoyad.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Kayıtlar kayit in Kayıt)
            {
                listBox1.Items.Add(kayit.Numara + " " + kayit.Ad + " " + kayit.Soyad);
            }
            listBox1.Items.Add("++++++++++++++++++++++++++++++++");
            listBox1.Items.Add("Toplam Kayıt Sayısı : " + Kayıt.Count);
        }
    }
}
