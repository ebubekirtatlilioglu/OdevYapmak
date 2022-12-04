using Ornek.sýnýflar;

namespace Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            BasePhone basePhone = new BasePhone();
            basePhone.CallSound();
        }

        private void btnNokia_Click(object sender, EventArgs e)
        {
           Nokia nokia = new Nokia();
            nokia.CallSound();
        }

        private void btnIphone_Click(object sender, EventArgs e)
        {
            Iphone iphone = new Iphone();
            iphone.CallSound();
        }

        private void btnSamsung_Click(object sender, EventArgs e)
        {
            Samsung isung = new Samsung();
            isung.CallSound();
        }
    }
}