using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.Scripts
{
    internal class Rekordlar
    {
        public Int32 id { get; set; }
        public String vaqt { get; set; }
        public Int32 hisob { get; set; }
        public Int32 xato { get; set; }
        public Int32 umumiyHisob { get; set; } //formLoadSanagich
        public String foiz { get; set; }
        public Rekordlar()
        {
        }
        public Rekordlar(Int32 i,String v, Int32 h, Int32 x, Int32 uH)
        {
            this.id = i;
            this.vaqt = v;
            this.hisob = h;
            this.xato = x;
            this.umumiyHisob = uH;
            this.foiz = Math.Round(h / (Double)uH,3).ToString();
        }
    }
}
