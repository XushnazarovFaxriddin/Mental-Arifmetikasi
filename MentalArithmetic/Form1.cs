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
            this.Hide();
            boshlashMA.ShowDialog();
            this.Show();
            //this.Show();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //this.Close();
            base.OnFormClosing(e);
            
        }
        private void tepaForm1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dasturHaqidaBtn_Click(object sender, EventArgs e)
        {
           Malumot malumot = new Malumot();
            this.Hide();
            malumot.ShowDialog();
            this.Show();
        }

        private void RekordlarimBtn_Click(object sender, EventArgs e)
        {
            Rekordlarim rekordlarim = new Rekordlarim();
            this.Hide();
            rekordlarim.ShowDialog();
            this.Show();
        }
    }
}
