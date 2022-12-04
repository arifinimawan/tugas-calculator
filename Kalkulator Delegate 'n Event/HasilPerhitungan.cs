using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Delegate__n_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HasilPerhitungan_OnPerhitungan (int index, int a, int b)
        {
            var hitung = new Calculator();

            if (index==0)
            {
                lstHasil.Items.Add(string.Format("Hasil Penjumlahan : {0} + {1} = {2}", a, b, hitung.Penambahan(a, b)));
                
            }
            else if (index==1)
            {
                lstHasil.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, hitung.Pengurangan(a, b)));
                
            }
            else if (index==2)
            {
                lstHasil.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", a, b, hitung.Perkalian(a, b)));
                
            }
            else
            {
                lstHasil.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, hitung.Pembagian(a, b)));
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Proses_Kalkulator proses = new Proses_Kalkulator();

            proses.OnPerhitungan += HasilPerhitungan_OnPerhitungan;
            proses.ShowDialog();
        }
    }
}
