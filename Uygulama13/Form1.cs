using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama13
{
    public partial class Form1 : Form
    {
        List<int> numaralarList = new List<int>();
        List<string> adsoyadList = new List<string>();
        List<Ogrenciler> ogrencilerList = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkleNesne_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.ogrenciNo = int.Parse(txtNumaraN.Text);
            ogrenci.ogrenciAdSoyad = txtAdSoyadN.Text;
            if (rbBay.Checked) ogrenci.ogrenciCinsiyet = true;
            else ogrenci.ogrenciCinsiyet = false;
            ogrencilerList.Add(ogrenci);
            lbNesne.Items.Clear();
                            
            foreach (var item in ogrencilerList)
            {
                if (item.ogrenciCinsiyet) cinsiyet = "bay";
                else cinsiyet = "bayan";
                lbNesne.Items.Add(item.ogrenciNo + " " + item.ogrenciAdSoyad+" "+cinsiyet);
            }
        }
    }
}
