using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaOyunu.Entitys
{
    public class Talep
    {
        public int talepId { get; set; }
        public int kullaniciId { get; set; }
        public string kullaniciAdi { get; set; }
        public double talepMiktari { get; set; }
    }
}
