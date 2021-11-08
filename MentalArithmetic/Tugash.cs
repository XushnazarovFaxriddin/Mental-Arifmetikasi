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
        public static String path = @"C:\Mental Arifmetikasi";
        public static Int32 id { get; set; } = 0;
        public static String vaqt { get; set; } = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        public static Int32 hisob { get; set; } = 0;
        public static Int32 xato { get; set; } = 0;
        public static Int32 umumiyHisob { get; set; } = 1; //formLoadSanagich
        public Tugash()
        {
            InitializeComponent();
        }
        static Int32 id_Func(Int32 Id)
        {
            try { 
            if (Directory.Exists($@"{path}\{Id}.txt"))
            {
                return id_Func(Id + 1);
            }
            }catch (Exception e) {
                return Id + 1;
            }
                return Id + 2;
        }
        static void file_Write()
        {
            try
            {
                //File.Create($@"{path}\{id}.txt");
                File.WriteAllText($@"{path}\{id}.txt", $@"{id}*{vaqt}*{hisob}*{xato}*{umumiyHisob}");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Tugash(Object _hisob, Object _xato, Object _umumiyHisob)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory($@"{path}");
            }
            id = id_Func(Directory.GetFiles(path).Length);
            hisob = (Int32)_hisob;
            xato = (Int32)_xato;
            umumiyHisob = (Int32)_umumiyHisob;
            InitializeComponent();
            file_Write();
        }
        private void BoshSahifaBtn_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            MentalArithmetic mentalArithmetic = new MentalArithmetic();
            mentalArithmetic.Visible = true;
            //this.Close();

        }

        private void qaytaOynashBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BoshlashMA boshla =new BoshlashMA();
            boshla.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            BoshSahifaBtn_Click(null,null);
            base.OnFormClosing(e);
        }
        private void Tugash_Load(object sender, EventArgs e)
        {
            hisobTxt.Text = hisob.ToString();
            
        }
    }
}
