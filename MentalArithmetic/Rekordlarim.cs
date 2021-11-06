using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        static String path=@"C:\Mental Arifmetikasi";
        private void Rekordlarim_Load(object sender, EventArgs e)
        {
            try { 
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory($@"{path}");
                }
                foreach (String item in Directory.GetFiles(path)) {
                    String[] file_Txt = File.ReadAllText(item).Split('*');
                    rekordlarBindingSource1.Add(new Rekordlar()
                    {
                        id = Convert.ToInt32(file_Txt[0]),
                        vaqt = file_Txt[1],
                        hisob = Convert.ToInt32(file_Txt[2]),
                        xato = Convert.ToInt32(file_Txt[3]),
                        umumiyHisob= Convert.ToInt32(file_Txt[4]),
                        foiz = (100*Math.Round(Convert.ToDouble(file_Txt[2]) / Convert.ToDouble(file_Txt[4]),3)).ToString()+"%"
                    });
                }
            }catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
