using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BurgerKing.Concrete;

namespace WFA_BurgerKing
{
    public partial class EkstraEkle : Form
    {
        public EkstraEkle()
        {
            InitializeComponent();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {


            SiparisOlustur.EkstraMalzemeEklemeListesi.Add(new EkstraMalzeme
            {
                Ad = txtExtraAd.Text,
                Fiyat = numEkstraFiyat.Value
            });
        }
    }
}
