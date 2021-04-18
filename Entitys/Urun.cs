using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunu.Entitys
{
    public class Urun
    {
        public int urunID { get; set; }
        public int kullaniciID { get; set; }
        public string kullaniciAdi { get; set; }
        public string urunAdi { get; set; }
        public double urunKg { get; set; }
        public double urunFiyati { get; set; }
        public bool urunOnay { get; set; }
    }
}
