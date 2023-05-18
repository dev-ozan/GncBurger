using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BurgerKing.Concrete
{
    public class Menuler
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return "Menü Adı : " + Ad;

        }
    }
}
