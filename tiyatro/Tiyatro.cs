using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiyatro
{
    internal class Tiyatro
    {
        private string v1;
        private string v2;
        private DateTime dateTime;
        private int v3;
        private int v4;

        public string Oyun {  get; set; }
        public string Sahne { get; set; }
        public DateTime KayitTarih { get; set; }
        public int Sure { get; set; }
        public int Fiyat { get; set; }
        public bool Muzikal {  get; set; }

        public Tiyatro(string oyun, string sahne, DateTime kayitTarih, int sure, int fiyat, bool muzikal) 
        {
            Oyun = oyun;
            Sahne = sahne;
            KayitTarih = kayitTarih;
            Sure = sure;
            Fiyat = fiyat;
            Muzikal = muzikal;
        }

        public Tiyatro(string v1, string v2, DateTime dateTime, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dateTime = dateTime;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
