using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.Scripts
{
    internal class Rekordlar
    {
        public int id { get; set; }
        public string vaqt {get; set; }
        public int hisob { get; set; }
        public int xato { get; set; }
        public int umumiyHisob { get; set; } //formLoadSanagich
        public double foiz { get; set; }
        public Rekordlar()
        {
        }
        public Rekordlar(int i,string v, int h, int x, int uH)
        {
            this.id = i;
            this.vaqt = v;
            this.hisob = h;
            this.xato = x;
            this.umumiyHisob = uH;
            this.foiz = h / uH;
        }
    }
}
