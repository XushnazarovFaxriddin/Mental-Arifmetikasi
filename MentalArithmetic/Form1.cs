using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MentalArithmetic
{
    public partial class MentalArithmetic : Form
    {
        
        public MentalArithmetic()
        {
            InitializeComponent();
        }

        private void MentalArithmetic_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoshlashMA boshlashMA = new BoshlashMA();
            boshlashMA.Show();
            //  DialogResult dialog=new DialogResult()
            this.Hide();
            if (boshlashMA.DialogResult == DialogResult.Cancel)
                this.Show();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tepaForm1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dasturHaqidaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".NET developer Faxriddin Xushnazarov");
        }

        private void RekordlarimBtn_Click(object sender, EventArgs e)
        {
            Rekordlarim rekordlarim = new Rekordlarim();
            rekordlarim.Show();
        }
    }
}
