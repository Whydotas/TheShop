using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop
{
    public partial class MuchShopSuchBuy : Form
    {
        public MuchShopSuchBuy()
        {
            InitializeComponent();
        }

        public void MuchShopSuchBuy_Load(object sender, EventArgs e)
        {
            Preke PrekeA = new Preke("PrekeA", 5, 10);
            Preke PrekeB = new Preke("PrekeB", 10, 20);
            Preke PrekeC = new Preke("PrekeC", 15, 30);

            PrekeA_TxtBox.Text = PrekeA.Kaina.ToString();
            PrekeB_TxtBox.Text = PrekeB.Kaina.ToString();
            PrekeC_TxtBox.Text = PrekeC.Kaina.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Prideti_BTN_Click(object sender, EventArgs e)
        {
            Dictionary<Preke, int> Kasikas = new Dictionary<Preke, int>();

            Preke PrekeA = new Preke("PrekeA", 5, 10);
            Preke PrekeB = new Preke("PrekeB", 10, 20);
            Preke PrekeC = new Preke("PrekeC", 15, 30);
            SiuntaDydisTxtBox.Text = "";

            if (numericUpDown1.Value > 0 || numericUpDown2.Value > 0 || numericUpDown3.Value > 0)
            {
                Kasikas.Add(PrekeA, Convert.ToInt32(numericUpDown1.Value));
                Kasikas.Add(PrekeB, Convert.ToInt32(numericUpDown2.Value));
                Kasikas.Add(PrekeC, Convert.ToInt32(numericUpDown3.Value));

                var BendrasSvoris = PrekeA.Svoris * Kasikas[PrekeA] + PrekeB.Svoris * Kasikas[PrekeB] + PrekeC.Svoris * Kasikas[PrekeC];
                var KrepselioKaina = PrekeA.Kaina * Kasikas[PrekeA] + PrekeB.Kaina * Kasikas[PrekeB] + PrekeC.Kaina * Kasikas[PrekeC];

                Krepselis_TxtBox.Text = KrepselioKaina.ToString();
                SiuntaSvorisTxtBox.Text = BendrasSvoris.ToString();
                
            }
            else
            {
                Krepselis_TxtBox.Text = "";
                SiuntaSvorisTxtBox.Text = "";
                MessageBox.Show("Gal bent vieną prekę įsidėsi?");
            }



        }

        private void Patvirtinti_BTN_Click(object sender, EventArgs e)
        {
            if (SiuntaSvorisTxtBox.Text != "" && Krepselis_TxtBox.Text != "")
            {
                Siunta siunta = new Siunta(double.Parse(SiuntaSvorisTxtBox.Text), double.Parse(Krepselis_TxtBox.Text));
                siunta.SetSiuntosDydis();
                SiuntaDydisTxtBox.Text = siunta.SiuntosDydis.ToString();
                if(PristatymoBox.Text != "")
                {
                    siunta.SetSiuntimoBudas(PristatymoBox.Text);
                    siunta.GetSiuntimoKaina();
                    siunta.GetSiuntosKaina();
                    TotalKainaTxtBox.Text = siunta.SiuntosKaina.ToString();
                }
                else
                {
                    MessageBox.Show("Susimildamas pasirink siuntimo buda!");
                }

             }       
           

        }

        private void Krepselis_TxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PristatymoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SiuntaSvorisTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SiuntaDydisTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalKainaTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apmoketi_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atsiprašome, bet dėl globalinės pandemijos mes bankrutavome :(");
        }
    }
}



