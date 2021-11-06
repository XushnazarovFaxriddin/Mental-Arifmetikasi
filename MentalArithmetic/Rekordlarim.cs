using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MentalArithmetic.Scripts;
namespace MentalArithmetic
{
    public partial class Rekordlarim : Form
    {
        public Rekordlarim()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rekordlarim_Load(object sender, EventArgs e)
        {
            for(int i = 1;i<35; i++)
            rekordlarBindingSource1.Add(new Rekordlar()
            {
                id = i,
                vaqt = "12.02.2021 18:37",
                hisob = 12+i,
                xato = 3+i,
                umumiyHisob=18+i,
                foiz = Math.Round((12+i) / (i+18.0),3)
            });
        }
    }
}
