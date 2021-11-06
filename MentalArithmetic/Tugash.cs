using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MentalArithmetic
{
    public partial class Tugash : Form
    {
        public Int32 hisob { get; set; }
        public Tugash()
        {
            InitializeComponent();
        }
        public Tugash(object hisob)
        {
            this.hisob = Convert.ToInt32(hisob);

            InitializeComponent();
        }
        private void BoshSahifaBtn_Click(object sender, EventArgs e)
        {
            MentalArithmetic mentalArithmetic = new MentalArithmetic();
            mentalArithmetic.Visible = true;
            this.Close();

        }

        private void qaytaOynashBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BoshlashMA boshla =new BoshlashMA();
            boshla.Show();
        }

        private void Tugash_Load(object sender, EventArgs e)
        {
            hisobTxt.Text = hisob.ToString();
            if(!Directory.Exists(@"C:\Program Files\MentalArifmetikasi"))
            {
                Directory.CreateDirectory(@"C:\Program Files\MentalArifmetikasi");
            }
        }
    }
}
