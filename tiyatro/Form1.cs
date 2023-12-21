using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiyatro
{
    public partial class Form1 : Form
    {
        BindingList<Tiyatro> oyunlar = new BindingList<Tiyatro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string oyunAd = cmbOyun.Text;
            string sahne = cmbSahne.Text;
            DateTime tarih = DateTime.Now;
            int sure = Convert.ToInt32(numericUpDown1.Value);
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            bool muzikal = cbMuzikal.Checked;

            Tiyatro oyun = new Tiyatro(oyunAd, sahne, tarih, sure, fiyat, muzikal);

            oyunlar.Add(oyun);

            dtvBilgi.Refresh();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dtvBilgi.SelectedRows.Count > 0)
            {
                Tiyatro tiyatro = (Tiyatro)dtvBilgi.SelectedRows[0].DataBoundItem;

                tiyatro.Oyun = cmbOyun.Text;
                tiyatro.Sahne = cmbSahne.Text;
                tiyatro.KayitTarih = dtpTarih.Value;
                tiyatro.Sure = Convert.ToInt32(numericUpDown1.Value);
                tiyatro.Muzikal = cbMuzikal.Checked;

                dtvBilgi.Refresh();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tiyatro tiyatro1 = new Tiyatro("Karagöz", "ZEYTİNBURNU SAHNESİ", new DateTime(2023, 07, 14), 80, 50, true);
            Tiyatro tiyatro2 = new Tiyatro("Halk seyirlik oyunları", "ENEZ B. KÜLTÜR VE SANAT MERKEZİ", new DateTime(2023, 10, 02), 40, 50, false);
            Tiyatro tiyatro3 = new Tiyatro("Hokkabazlık", "EDİRNE B. ATATÜRK KÜLTÜR MERKEZİ", new DateTime(2023, 11, 19), 50, 50, true);
            Tiyatro tiyatro4 = new Tiyatro("Orta Oyunu", "İPSALA B. KÜLTÜR VE SANAT MERKEZİ", new DateTime(2023, 08, 30), 45, 50, false);

            oyunlar.Add(tiyatro1);
            oyunlar.Add(tiyatro2);
            oyunlar.Add(tiyatro3);
            oyunlar.Add(tiyatro4);

            dtvBilgi.DataSource = oyunlar;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtvBilgi.SelectedRows.Count > 0)
            {
                Tiyatro oyun = (Tiyatro)dtvBilgi.SelectedRows[0].DataBoundItem;

                DialogResult sonuc = MessageBox.Show(oyun.Oyun + " Silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {

                    oyunlar.Remove(oyun);

                }
            }

        }
    }
    }
