using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        decimal toplamMiktar = 0;
        Kumbara kumbara = new Kumbara();
        Money money = new Money();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbParaTipi.Items.AddRange(new string[] { "Bozuk Para", "Kağıt Para" });
            cmbMiktar.Enabled = false;
            btnYapıştır4.Enabled = false;
            //Kumbara kumbara = new Kumbara();
            kumbara.kullanilanHacim = 0;
        }

        private void cmbParaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedParaTipi = cmbParaTipi.SelectedItem as string;

            if (cmbParaTipi.SelectedItem == "Bozuk Para")
            {
                cmbMiktar.Enabled = true;
                cmbMiktar.DataSource = Money.BozukParaMiktarlari;
            }
            else if (selectedParaTipi == "Kağıt Para")
            {
                cmbMiktar.Enabled = true;
                cmbMiktar.DataSource = Money.KagıtParaMiktarlari;
            }

        }

        private void cmbMiktar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            decimal secilenMiktar = Convert.ToDecimal(cmbMiktar.SelectedItem);
            toplamMiktar = secilenMiktar + toplamMiktar;
            Money money = new Money();
            money.toplamMiktar = toplamMiktar;
            double kagitParaHacmi = kumbara.hacimHesaplaKagitPara();
            double bozukParaHacmi = kumbara.hacimHesaplaBozukPara();
            kumbara.kullanilanHacim = kagitParaHacmi + bozukParaHacmi;
            // burayı çalıştıramadım ..
            if (cmbParaTipi.SelectedItem.ToString() == "Bozuk Para")
            {   
                if (kumbara.kullanilanHacim <= kumbara.kumbaraToplamHacmi)
                {
                    MessageBox.Show(cmbMiktar.SelectedItem.ToString() + " tl eklendi");
                }
                else
                {
                    MessageBox.Show("Kumbara doldu sallamayı deneyebilirsin .");
                }
            }
            else
            {                
                if (kumbara.kullanilanHacim <= kumbara.kumbaraToplamHacmi)
                {
                    MessageBox.Show(cmbMiktar.SelectedItem.ToString() + " tl eklendi");
                }
                else
                {
                    MessageBox.Show("Kumbara doldu sallamayı deneyebilirsin .");
                }
            }
        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
            kumbara.kullanilanHacim = kumbara.kullanilanHacim * 0.8;
            MessageBox.Show("Tebrikler kumbaranızda yer açıldı tekrar para eklemeyi deneyebilirsiniz");
        }

        public bool butonKirTiklandi = false;

        private void btnKır_Click(object sender, EventArgs e)
        {
            if (!butonKirTiklandi)
            {
                
                butonKirTiklandi = true;
                btnYapıştır4.Enabled = true;
                MessageBox.Show("Kumbaranızdaki para : " + toplamMiktar.ToString() + " tl");
                MessageBox.Show("Kumbarayı kırıldı fakat üzülmeyin 1 kez de olsa tekrar yapıştırabilirsiniz !");
            }
            else
            {
                MessageBox.Show("Kumbaranızdaki para : " + toplamMiktar.ToString() + " tl");
                btnKır.Enabled = false;
                btnEkle.Enabled = false;
                btnSalla.Enabled = false;
                MessageBox.Show($"{toplamMiktar} tlnizi güle güle harcayın :)");
                Application.Exit();
            }
        }

        private void btnYapıştır4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kumbaranız yapıstirildi" +
                $"şu an kumbaranızda {toplamMiktar} tl var" +
                " ancak tekrar kırarsanız bir daha yapıştıramazsınız " +
                "haberiniz olsun demedi demeyin !");
            btnYapıştır4.Enabled = false;
        }
    }
}
