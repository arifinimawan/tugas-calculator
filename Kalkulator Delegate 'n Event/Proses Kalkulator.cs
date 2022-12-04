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
    public partial class Proses_Kalkulator : Form
    {
        public delegate void CalculatorEventHandler(int index, int a, int b);
        public event CalculatorEventHandler OnPerhitungan;

        public Proses_Kalkulator()
            
        {
            InitializeComponent();
            cmbOperasi.Items.Add("Penjumlahan");
            cmbOperasi.Items.Add("Pengurangan");
            cmbOperasi.Items.Add("Perkalian");
            cmbOperasi.Items.Add("Pembagian");
            cmbOperasi.SelectedIndex = 0;
            cmbOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Proses_Kalkulator_Load(object sender, EventArgs e)
        {
          

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(txtNilaiA.Text);
            int NilaiB = int.Parse(txtNilaiB.Text);

            if (cmbOperasi.SelectedIndex==0)
            {
                OnPerhitungan(0, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex==1)
            {
                OnPerhitungan(1, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex==2)
            {
                OnPerhitungan(2, NilaiA, NilaiB);
            }
            else 
            {
                OnPerhitungan(3, NilaiA, NilaiB);
            }
        }
    }
}
