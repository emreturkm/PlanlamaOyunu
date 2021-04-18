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
using PlanlamaOyunu.Entitys;
using PlanlamaOyunu.SqlQuerys;

namespace PlanlamaOyunu
{
    public partial class GirisKayitFrm : Form
    {
        public GirisKayitFrm()
        {
            InitializeComponent();
        }
        GirisKayitFrmQuerys grsKytFrmQrys = new GirisKayitFrmQuerys();

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (txtBoxGirisKullaniciAdi.Text.Trim() != "" && txtBoxGirisSifre.Text.Trim() != "")
            {
                try
                {
                    Kullanici kllnc = new Kullanici();
                    kllnc = grsKytFrmQrys.girisKontrol(txtBoxGirisKullaniciAdi.Text.Trim(), txtBoxGirisSifre.Text.Trim());//login servise gönderilen kullanıcı adı ve şifresine sahip kullanıcı var mı diye veritabanında sorgu yaptırıyoruz
                    if (kllnc != null)//sorgudan bir sonuç çıkarsa yani kllnc nın içinde yetki degeri doluysa if e giriyor
                    {
                        if (kllnc.yetki == "ALICI")
                        {
                            this.Hide();
                            Forms.AliciMenuFrm aliciMenuFrm = new Forms.AliciMenuFrm();
                            aliciMenuFrm.StartPosition = FormStartPosition.CenterScreen;
                            aliciMenuFrm.Closed += (s, args) => this.Close();
                            aliciMenuFrm.Show();
                        }
                        else if (kllnc.yetki == "SATICI")
                        {
                            this.Hide();
                            Forms.SaticiMenuFrm saticiMenuFrm = new Forms.SaticiMenuFrm();
                            saticiMenuFrm.StartPosition = FormStartPosition.CenterScreen;
                            saticiMenuFrm.Closed += (s, args) => this.Close();
                            saticiMenuFrm.Show();
                        }
                        else
                        {
                            this.Hide();
                            Forms.AdminMenuFrm adminMenuFrm = new Forms.AdminMenuFrm();
                            adminMenuFrm.StartPosition = FormStartPosition.CenterScreen;
                            adminMenuFrm.Closed += (s, args) => this.Close();
                            adminMenuFrm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı mevcut değil veya şifreniz yanlış!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void KayıtBtn_Click(object sender, EventArgs e)
        {
            if (txtBoxAd.Text.Trim() == "" || txtBoxSoyad.Text.Trim() == "" || txtBoxKullaniciAdi.Text.Trim() == "" || 
                txtBoxSifre.Text.Trim() == "" || txtBoxTcNo.Text.Trim() == ""
                 || txtBoxTelefonNo.Text.Trim() == "" || txtBoxMail.Text.Trim() == "" || txtBoxAdres.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız!");
            }
            else
            {
                kayitOl();
            }
        }
        public void kayitOl()
        {

            if (grsKytFrmQrys.kayitKontrol(txtBoxKullaniciAdi.Text.Trim(), txtBoxTcNo.Text.Trim(), txtBoxTelefonNo.Text.Trim(), txtBoxMail.Text.Trim()))//parametre olarak gönderilenler başka kullanıcıda aynı mı diye kontrol ediyor
            {
                string yetki = "";
                if (aliciRbtn.Checked)//alıcı olarak kayıt yapacaksak yetkiyi alıcı diye kaydediyor
                {
                    yetki = "ALICI";
                    
                }
                else if (saticiRbtn.Checked)//satıcı olarak kayıt yapacaksak yetkiyi satıcı diye kaydediyor
                {
                    yetki = "SATICI";
                }
                grsKytFrmQrys.kayitOl(txtBoxAd.Text.Trim(), txtBoxSoyad.Text.Trim(), txtBoxKullaniciAdi.Text.Trim(), txtBoxSifre.Text.Trim(),
                        txtBoxTcNo.Text.Trim(), txtBoxTelefonNo.Text.Trim(), txtBoxMail.Text.Trim(), txtBoxAdres.Text.Trim(), yetki);
            }
            else
            {
                MessageBox.Show("Aynı Kullanıcı adı, TC No, Telefon No veya Email'e sahip kullanıcı mevcuttur.");
            }
        }

    }
}
