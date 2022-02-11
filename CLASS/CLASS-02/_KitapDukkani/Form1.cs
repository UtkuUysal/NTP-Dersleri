using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KitapDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Yazar> yzr = new List<Yazar>();
        List<Kitaplar> kitaplar = new List<Kitaplar>();
        List<Müşteri> musteriler = new List<Müşteri>();
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
            yazar.Adi = txtYazarAdi.Text;
            yazar.DoğumTarihi = dtYazarDogumTarihi.Value;
            if (chkNobel.Checked==true)
            {
                yazar.NobelÖdülüVarMİ=true;
            }
            else
	{
                yazar.NobelÖdülüVarMİ=false;
	}
            yzr.Add(yazar);
            cmbYazar.Items.Add(yazar);
            cmbYazar.DisplayMember=("Yazar");
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapTürü = cmbKitapTuru.SelectedItem.ToString();
            kitap.SayfaSayisi = int.Parse(txtSayfaSayisi.Text);
            kitap.Fiyat = decimal.Parse(txtFiyat.Text);
            kitap.YazarBil = (Yazar)cmbYazar.SelectedItem;
            kitaplar.Add(kitap);
            cmbKitap.Items.Add(kitap);
            cmbKitap.DisplayMember = "KitapAdi";
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Müşteri müsteri = new Müşteri();
            müsteri.MüşteriAdi = txtMusteriAdi.Text;
            müsteri.Meslek = txtMeslegi.Text;
             müsteri.Kitap = (Kitaplar)cmbKitap.SelectedItem;
             müsteri.Yaş = int.Parse(txtMusteriYas.Text);
             musteriler.Add(müsteri);
            
            cmbKitap.DisplayMember = ("Kitap");
        }

        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            lsbMusteriler.Items.Clear();
            lsbMusteriler.Items.Add("Adı Meslek KitapAdı Yaş");
            foreach (Müşteri Kayıtlar in musteriler)
            {
                lsbMusteriler.Items.Add(Kayıtlar.MüşteriAdi + " " + Kayıtlar.Meslek + " " + Kayıtlar.Kitap + " " + Kayıtlar.Yaş);
            }
        }


       
        
    }
}
