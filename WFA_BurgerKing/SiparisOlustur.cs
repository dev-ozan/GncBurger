using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BurgerKing.Concrete;

namespace WFA_BurgerKing
{


    public partial class SiparisOlustur : Form
    {

        // Statik bir liste tanımladık ki diğer sınıflar tarafından erişilebilsin.
        public static List<EkstraMalzeme> EkstraMalzemeEklemeListesi = new()
        {
             new EkstraMalzeme {Ad = "Ketcap" , Fiyat =3 },
             new EkstraMalzeme {Ad = "Mayonez" , Fiyat =2.75M },
             new EkstraMalzeme {Ad = "Hardal" , Fiyat =3.25M },
             new EkstraMalzeme {Ad = "Ballı Hardal" , Fiyat =4M },
             new EkstraMalzeme {Ad = "Barbekü Sos" , Fiyat =2.40M },
             new EkstraMalzeme {Ad = "Ranchzzzzzzzzzz" , Fiyat =4 },
             new EkstraMalzeme {Ad = "Sarımsaklı Mayonez" , Fiyat =1M },

        };

        // Menü listesi de ekleyeceğiz.

        public SiparisOlustur()
        {
            int y = 30;
            InitializeComponent();
            foreach (var item in EkstraMalzemeEklemeListesi)
            {

                groupBoxEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.Ad, Location = new Point { X = 10, Y = y }, AutoSize = false, Width = groupBoxEkstraMalzemeler.Width });
                y += 22;

            }

        }
    }
}
