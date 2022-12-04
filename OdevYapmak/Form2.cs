using OdevYapmak.sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevYapmak
{
    public partial class Form2 : Form
    {
        private List<Ogrenci> _ogrenciler;
        private List<Ders> _dersler;
        List<OgrenciDersi> _ogrenciDersleri = new List<OgrenciDersi>();


        public Form2(List<Ogrenci> ogrenciler, List<Ders> dersler, List<OgrenciDersi> ogrenciDersleri)
        {
            InitializeComponent();
            _ogrenciler = ogrenciler;
            _dersler = dersler;
            _ogrenciDersleri= ogrenciDersleri;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BilgileriGetir();
            OgrencidersleriListele();
        }
        private void BilgileriGetir()
        {
            cmbOgrenci.Items.Add("seçiniz");
            cmbDers.Items.Add("seçiniz");
            foreach (var item in _ogrenciler)
            {
                cmbOgrenci.Items.Add(item);
            }
            foreach (var item in _dersler)
            {
                cmbDers.Items.Add(item);
            }
            cmbOgrenci.SelectedIndex = 0;
            cmbDers.SelectedIndex = 0;
        }

        private void btnOgrenciDersiekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OgrenciDersiEklenebilirMi())
                {
                    MessageBox.Show("lütfen boş bırakma...");
                    return;
                }
                foreach (var item in _ogrenciDersleri)
                {
                    if (item.Ogrenci==(Ogrenci)(cmbOgrenci.SelectedItem)&&item.Ders==(Ders)cmbDers.SelectedItem))
                    {
                        MessageBox.Show("seçtiğiniz ders öğrenciye zaten ekleniştir");
                        return;
                    }
                }
                OgrenciDersi ogrenciDersi = new OgrenciDersi();
                ogrenciDersi.Ogrenci = (Ogrenci)(cmbOgrenci.SelectedItem);
                ogrenciDersi.Ders = (Ders)cmbDers.SelectedItem;
                _ogrenciDersleri.Add(ogrenciDersi);
                MessageBox.Show("öğrenci dersi eklenmiştir");
                OgrencidersleriListele();

            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluştu."+ex.Message);
            
            }
          
        }
        private bool OgrenciDersiEklenebilirMi()
        {
            if (cmbOgrenci.SelectedIndex==0|| cmbDers.SelectedIndex==0 )
            {
                return false;
            }
            return true;
        }
        private void OgrencidersleriListele()
        {
            lstOgrenciDersleri.Items.Clear();
            if (_ogrenciDersleri!=null)
            {
                foreach (var item in _ogrenciDersleri)
                {
                    lstOgrenciDersleri.Items.Add(item);

                }
            }
           
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 eskiForm=new Form1(_ogrenciler,_dersler, _ogrenciDersleri);
            eskiForm.Show();
            Close();
        }
    }
}
