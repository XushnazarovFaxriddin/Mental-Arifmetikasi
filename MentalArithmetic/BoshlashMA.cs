using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MentalArithmetic.Scripts;

namespace MentalArithmetic
{
    public partial class BoshlashMA : Form
    {
        
        static int hisobSanagich = 0, xatoSanagich = 0, formLoadSanagich = 0;
        Double qolganVaqt=1000;
        static int number=0;
        static List<string> RandomBtnElements ,listProgress;
        Hisoblash hisoblash = new Hisoblash();
        Misollar misollar1 = new Misollar();
        MentalArithmetic mentalArithmetic = new MentalArithmetic();
        public BoshlashMA()
        {
            hisobSanagich = 0;
            xatoSanagich = 0;  
            formLoadSanagich= 0;
            InitializeComponent();
            timer.Interval = 10;
            PrograssReport.Maximum = 650;
        }
        
        static string javob="", misolString="";
        static Random randomMA = new Random();
        private void BoshlashMA_Load(object sender, EventArgs e)
        {
            qolganVaqt = 1000;
            if (formLoadSanagich < 1)
                timer.Tick += timer_Tick;
            timer.Enabled = true;
            formLoadSanagich++;
            PrograssReport.Value = 650;
            if(xatoSanagich!=0)
                switch (xatoSanagich)
                {
                    case 1: loveImage1.ImageLocation = "o'zgar"; break;
                    case 2: loveImage2.ImageLocation = "o'zgar"; break;
                    case 3: loveImage3.ImageLocation = "o'zgar"; break;
                    default:Tugash tugash=new Tugash(hisobSanagich); tugash.Show(); this.Visible=false; break;
                }
            ABtn.ForeColor = Color.Black;
            BBtn.ForeColor = Color.Black;
            CBtn.ForeColor = Color.Black;
            ABtn.BackColor = Color.White;
            BBtn.BackColor = Color.White;
            CBtn.BackColor = Color.White;
            ABtn.Enabled = true;
            BBtn.Enabled = true;
            CBtn.Enabled = true;
            sanagichTxt.Text = hisobSanagich.ToString();
            RandomBtnElements = new List<string>();
            misol1Txt.Text = misollar1.RandomSon().ToString();
            amal1Txt.Text = misollar1.RandomAmal().ToString();
            misol2Txt.Text = misollar1.RandomSon().ToString();
            misolString = misol1Txt.Text + amal1Txt.Text + misol2Txt.Text;
            javob = hisoblash.Eval(misolString);
            if (int.TryParse(javob, out number))
            {
                RandomBtnElements.Add(misollar1.RandomSonInterval(number).ToString());
                RandomBtnElements.Add(misollar1.RandomSonInterval(number).ToString());
            }
            else
            {
                RandomBtnElements.Add(Math.Round(randomMA.NextDouble(), 4).ToString());
                RandomBtnElements.Add(Math.Round(randomMA.NextDouble(), 4).ToString());
            }
            RandomBtnElements.Add(javob);
            ABtn.Text = misollar1.RandomElementBtn(RandomBtnElements,"bu 1-bo'gani uchun","bunga farqi yoq");
            BBtn.Text = misollar1.RandomElementBtn(RandomBtnElements, ABtn.Text, "bu 2-bo'gani un farqi yoq");
            CBtn.Text = misollar1.RandomElementBtn(RandomBtnElements, ABtn.Text, BBtn.Text);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (PrograssReport.Value < 4)
            {
                PrograssReport.ForeColor = Color.Red;
            }
            else
            {
                PrograssReport.ForeColor= Color.Green;
            }
            if (PrograssReport.Value > 0)
            {
                PrograssReport.Value--;
                qolganVaqtTxt.Text = Math.Round((qolganVaqt-=1.5)/100).ToString();
            }
            else
            {
                timer.Enabled = false;
                xatoSanagich++;
                CBtn.ForeColor = Color.White;
                ABtn.ForeColor = Color.White;
                BBtn.ForeColor = Color.White;
                ABtn.Enabled = false;
                BBtn.Enabled = false;
                CBtn.Enabled = false;
                if (funcBtn("ABtn", ABtn.Text))
                {
                    ABtn.BackColor = Color.Lime;
                    BBtn.BackColor = Color.Red;
                    CBtn.BackColor = Color.Red;
                }
                else
                {
                    ABtn.BackColor = Color.Red;
                    if (funcBtn("BBtn", BBtn.Text))
                    {
                        BBtn.BackColor = Color.Lime;
                        CBtn.BackColor = Color.Red;
                    }
                    else
                    {
                        CBtn.BackColor = Color.Lime;
                        BBtn.BackColor = Color.Red;
                    }
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);
            DialogResult dr = MessageBox.Show("Haqiqatdan ham o'yinni toxtatmoqchomosiz?",
                      "Mental arithmetic", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    mentalArithmetic.Show();
                    e.Cancel=false;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void refleshBtn_Click(object sender, EventArgs e)
        {
            BoshlashMA_Load(sender,e);
        }
        static void HisobTimer()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
        }
        private void tepaForm1Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private static bool funcBtn(string btn, string btnTxt)
        {
            if (btn == "ABtn")
            {
                if(btnTxt == javob)
                {
                    return true;
                }
                return false;
            }
            if(btn == "BBtn")
            {
                if(btnTxt == javob)
                {
                    return true;
                }
                return false;
            }
            if(btn == "CBtn")
            {
                if(btnTxt == javob)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        private void ABtn_Click(object sender, EventArgs e)
        {
            timer.Enabled=false;
            CBtn.ForeColor = Color.White;
            ABtn.ForeColor = Color.White;
            BBtn.ForeColor = Color.White;
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            if (funcBtn("ABtn", ABtn.Text))
            {
                hisobSanagich++;
                ABtn.BackColor = Color.Lime;
                BBtn.BackColor = Color.Red;
                CBtn.BackColor = Color.Red;
            }
            else
            {
                xatoSanagich++; 
                ABtn.BackColor = Color.Red;
                if (funcBtn("BBtn", BBtn.Text))
                {
                    BBtn.BackColor = Color.Lime;
                    CBtn.BackColor = Color.Red;
                }
                else
                {
                    CBtn.BackColor = Color.Lime;
                    BBtn.BackColor= Color.Red;
                }
            }
        }

        private void BBtn_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            CBtn.ForeColor = Color.White;
            ABtn.ForeColor = Color.White;
            BBtn.ForeColor = Color.White;
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            if (funcBtn("BBtn", BBtn.Text))
            {
                hisobSanagich++;
                ABtn.BackColor = Color.Red;
                BBtn.BackColor = Color.Lime;
                CBtn.BackColor = Color.Red;
            }
            else
            {
                xatoSanagich++;
                BBtn.BackColor = Color.Red;
                if (funcBtn("ABtn", ABtn.Text))
                {
                    hisobSanagich++;
                    ABtn.BackColor = Color.Lime;
                    CBtn.BackColor = Color.Red;
                }
                else
                {
                    CBtn.BackColor = Color.Lime;
                    ABtn.BackColor = Color.Red;
                }
            }

        }

        private void sanagichTxt_Click(object sender, EventArgs e)
        {

        }

        private void tepaForm1Panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            CBtn.ForeColor = Color.White;
            ABtn.ForeColor = Color.White;
            BBtn.ForeColor= Color.White;
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            if (funcBtn("CBtn", CBtn.Text))
            {
                hisobSanagich++;
                ABtn.BackColor = Color.Red;
                BBtn.BackColor = Color.Red;
                CBtn.BackColor = Color.Lime;
            }
            else
            {
                xatoSanagich++;
                CBtn.BackColor = Color.Red;
                if (funcBtn("BBtn", BBtn.Text))
                {
                    BBtn.BackColor = Color.Lime;
                    ABtn.BackColor = Color.Red;
                }
                else
                {
                    ABtn.BackColor = Color.Lime;
                    BBtn.BackColor = Color.Red;
                }
            }
        }
    

        private void PrograssReport_Click(object sender, EventArgs e)
        {
           
        }

        private void misollarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
