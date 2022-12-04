using OdevYapmak.sýnýflar;

namespace OdevYapmak
{
    public partial class Form1 : Form
    {
        List<Danisman> danismanlar = new List<Danisman>();
        List<Ogrenci> _ogrenciler = new List<Ogrenci>();
        List<OgrenciDersi> _ogrenciDersleri= new List<OgrenciDersi>();
        List<Ders> _dersler = new List<Ders>();


        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Ogrenci> ogrenciler , List<Ders> dersler,List<OgrenciDersi> ogrenciDersleri)
        {
            InitializeComponent();
            _ogrenciDersleri= ogrenciDersleri;
            _dersler= dersler;
            _ogrenciler = ogrenciler;
            OgerncileriListele();
            DersleriListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDanisman.Items.Add("seçiniz");

            Danisman danisman = new Danisman();
            danisman.Ad = "ibrahim";
            danisman.Soyad = "ibrahimoðlu";
            danismanlar.Add(danisman);

            Danisman danisman2= new Danisman();
            danisman2.Ad = "ahmet";
            danisman2.Soyad = "mehmetoðlu";
            danismanlar.Add(danisman2);


            Danisman danisman3 = new Danisman();
            danisman3.Ad = "kemal";
            danisman3.Soyad = "ahmetler";
            danismanlar.Add(danisman3);

            foreach (var item in danismanlar)
            {
                cmbDanisman.Items.Add(item);
            }
            cmbDanisman.SelectedIndex = 0;
            zorunlurdo.Checked = true;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!OgrenciEklenebilirMi())
                {
                    MessageBox.Show("lütfen boþ býrakma");
                    return;
                }
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ad = txtAd.Text;
                ogrenci.Soyad = txtSoyad.Text;
                ogrenci.OgrenciNumarasi = txtNO.Text;
                ogrenci.Danisman = (Danisman)(cmbDanisman.SelectedItem);
                ogrenci.Bolumu = txtBolum.Text;
                _ogrenciler.Add(ogrenci);
                MessageBox.Show("öðrenciler eklendi.");
                OgerncileriListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluþtu!"+ex.Message);
            }
          
           
        }
        private bool OgrenciEklenebilirMi()
        {
            if (string.IsNullOrEmpty( txtAd.Text)||string.IsNullOrEmpty(txtSoyad.Text)||string.IsNullOrEmpty(txtBolum.Text)||string.IsNullOrEmpty(txtNO.Text)||cmbDanisman.SelectedIndex==0)
            {
                return false;
            }
           
            return true;
            
        }
        private bool DersEklenebilirMi()
        {
            if (string.IsNullOrEmpty(txtDersAdi.Text) || string.IsNullOrEmpty(txtDersKodu.Text) || string.IsNullOrEmpty(txtKredi.Text))
            {
                return false;
            }

            return true;

        }
        private void OgerncileriListele()
        {
            lstOgrenciler.Items.Clear();
            foreach (var item in _ogrenciler)
            {
                lstOgrenciler.Items.Add(item);
            }
        }
        private void DersleriListele()
        {
            lstDersler.Items.Clear();
            foreach (Ders item in _dersler)
            {
                lstDersler.Items.Add(item);
            }
        }
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DersEklenebilirMi())
                {
                    MessageBox.Show("lütfen boþ býrakma");
                    return;
                }
                Ders ders = new Ders();
                ders.Ad = txtDersAdi.Text;
                ders.Kod = txtDersKodu.Text;
                ders.Kredi = Convert.ToInt32(txtKredi.Text);
                ders.ZorunluMu = zorunlurdo.Checked;
                _dersler.Add(ders);
                MessageBox.Show("ders eklenmiþtir.");
                DersleriListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluþtu."+ex.Message);
            }
          
        }

      

        private void btnOgrenciDersEkrani_Click(object sender, EventArgs e)
        {
            Form2 ogrenciDersEkrani = new Form2(_ogrenciler, _dersler,_ogrenciDersleri);
            Hide();
            ogrenciDersEkrani.ShowDialog();
        }
    }
}