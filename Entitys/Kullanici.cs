using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunu.Entitys
{
    public class Kullanici
    {
        public int kullaniciID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string tcNo { get; set; }
        public string telefonNo { get; set; }
        public string email { get; set; }
        public string adres { get; set; }
        public string yetki { get; set; }
        public double bakiye { get; set; }
    }
}
