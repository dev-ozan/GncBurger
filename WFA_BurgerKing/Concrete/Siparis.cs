using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BurgerKing.Concrete
{
    public class Siparis
    {
        public Menuler Menu { get; set; }

        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }


        public Boyut Boyut { get; set; }

        public int Adet { get; set; }


        public decimal ToplamTutar { get; set; }


        public void Hesapla()
        {


            ToplamTutar = Menu.Fiyat * Adet;


            if (Boyut == Boyut.Orta)
                ToplamTutar += ToplamTutar * 0.5M;
            else if (Boyut == Boyut.Buyuk)
                ToplamTutar += ToplamTutar * 0.75M;






            foreach (var ekstra in EkstraMalzemeler)
            {
                ToplamTutar += ekstra.Fiyat;
            }
            ToplamTutar = ToplamTutar * Adet;


        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Adet + " Adet Sipariş");
            sb.AppendLine(Menu.Ad + " Menü");
            sb.AppendLine("Ekstra Malzemeler");

            foreach (var ekstra in EkstraMalzemeler)
                sb.AppendLine(ekstra.Ad);

            sb.AppendLine(ToplamTutar.ToString());

            return sb.ToString();


        }



    }
}
