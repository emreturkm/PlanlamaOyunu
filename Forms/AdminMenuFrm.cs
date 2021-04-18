using PlanlamaOyunu.Entitys;
using PlanlamaOyunu.SqlQuerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunu.Forms
{
    public partial class AdminMenuFrm : Form
    {
        public AdminMenuFrm()
        {
            InitializeComponent();
        }
        public static string connectionSource = Properties.Settings.Default.SqlString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        AdminFrmQuerys admnFrmQrys = new AdminFrmQuerys();
        List<Urun> urnlr = new List<Urun>();
        Urun urn = new Urun();
        List<Talep> prTlplr = new List<Talep>();
        Talep prTlp = new Talep();
        private void AdminMenuFrm_Load(object sender, EventArgs e)
        {
            dtGrdViewUrunler.ColumnCount = 6;
            dtGrdViewUrunler.Columns[0].Name = "Ürün ID";
            dtGrdViewUrunler.Columns[1].Name = "Satıcı Kullanıcı Adı";
            dtGrdViewUrunler.Columns[2].Name = "Ürün adı";
            dtGrdViewUrunler.Columns[3].Name = "Ürün KG";
            dtGrdViewUrunler.Columns[4].Name = "Ürün Kg Fiyatı(TL)";
            dtGrdViewUrunler.Columns[5].Name = "Ürün Onayı";
            cmbBoxUrunFiltre.SelectedIndex = 0;

            dtGrdViewParalar.ColumnCount = 3;
            dtGrdViewParalar.Columns[0].Name = "Talep ID";
            dtGrdViewParalar.Columns[1].Name = "Kullanıcının Adı";
            dtGrdViewParalar.Columns[2].Name = "Talep Miktarı(TL)";
            prTlplr = admnFrmQrys.getAllParaTalep();
            dataGridViewParaTalepListele(prTlplr);
        }
        /*
         * ÜRÜN TALEPLERİ KISMI
         */
        private void cmbBoxUrunFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            urnlr.Clear();
            if (cmbBoxUrunFiltre.Text == "Hepsi")
            {
                urnlr = admnFrmQrys.getAllUrun();
            }
            else if (cmbBoxUrunFiltre.Text == "Onaylanmamış Ürünler")
            {
                urnlr = admnFrmQrys.getUrunByUrunOnay(false);
            }
            else if (cmbBoxUrunFiltre.Text == "Onaylanmış Ürünler")
            {
                urnlr = admnFrmQrys.getUrunByUrunOnay(true);
            }
            dataGridViewUrunListele(urnlr);
        }

        public void dataGridViewUrunListele(List<Urun> urnlr)
        {
            dtGrdViewUrunler.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dtGrdViewUrunler.Rows.Add();
                dtGrdViewUrunler.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dtGrdViewUrunler.Rows[i].Cells[1].Value = urnlr[i].kullaniciAdi;
                dtGrdViewUrunler.Rows[i].Cells[2].Value = urnlr[i].urunAdi;
                dtGrdViewUrunler.Rows[i].Cells[3].Value = urnlr[i].urunKg;
                dtGrdViewUrunler.Rows[i].Cells[4].Value = urnlr[i].urunFiyati;
                dtGrdViewUrunler.Rows[i].Cells[5].Value = urnlr[i].urunOnay;
            }
        }
        private void btnUrunOnayla_Click(object sender, EventArgs e)
        {
            if (dtGrdViewUrunler.SelectedRows.Count > 0)
            {
                admnFrmQrys.changeUrunOnay(Convert.ToInt32(dtGrdViewUrunler.SelectedRows[0].Cells[0].Value), true);
                dtGrdViewUrunler.SelectedRows[0].Cells[5].Value = true;
            }
        }

        private void btnUrunOnayKaldir_Click(object sender, EventArgs e)
        {
            if (dtGrdViewUrunler.SelectedRows.Count > 0)
            {
                admnFrmQrys.changeUrunOnay(Convert.ToInt32(dtGrdViewUrunler.SelectedRows[0].Cells[0].Value), false);
                dtGrdViewUrunler.SelectedRows[0].Cells[5].Value = false;
            }
        }

        /*
         * PARA TALEPLERİ KISMI
         */
        public void dataGridViewParaTalepListele(List<Talep> prTlplr)
        {
            dtGrdViewParalar.Rows.Clear();
            for (int i = 0; i < prTlplr.Count; i++)
            {
                dtGrdViewParalar.Rows.Add();
                dtGrdViewParalar.Rows[i].Cells[0].Value = prTlplr[i].talepId;
                dtGrdViewParalar.Rows[i].Cells[1].Value = prTlplr[i].kullaniciAdi;
                dtGrdViewParalar.Rows[i].Cells[2].Value = prTlplr[i].talepMiktari;
            }
        }
        private void btnParaOnayla_Click(object sender, EventArgs e)
        {
            if (dtGrdViewParalar.SelectedRows.Count > 0)
            {
                int talepId = Convert.ToInt32(dtGrdViewParalar.SelectedRows[0].Cells[0].Value);
                string kullaniciAdi = dtGrdViewParalar.SelectedRows[0].Cells[1].Value.ToString();
                double talepMiktari = Convert.ToDouble(dtGrdViewParalar.SelectedRows[0].Cells[2].Value);
                admnFrmQrys.confirmParaTalep(talepId, kullaniciAdi, talepMiktari);
                prTlplr.Clear();
                prTlplr = admnFrmQrys.getAllParaTalep();
                dataGridViewParaTalepListele(prTlplr);
            }
        }

        private void btnParaOnayiRet_Click(object sender, EventArgs e)
        {
            if (dtGrdViewParalar.SelectedRows.Count > 0)
            {
                admnFrmQrys.deleteParaTalepByTalepId(Convert.ToInt32(dtGrdViewParalar.SelectedRows[0].Cells[0].Value));
                prTlplr.Clear();
                prTlplr = admnFrmQrys.getAllParaTalep();
                dataGridViewParaTalepListele(prTlplr);
            }
        }

        private void btnTalepListeYenile_Click(object sender, EventArgs e)
        {
            prTlplr.Clear();
            prTlplr = admnFrmQrys.getAllParaTalep();
            dataGridViewParaTalepListele(prTlplr);
        }
    }
}
