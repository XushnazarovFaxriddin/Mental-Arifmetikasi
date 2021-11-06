using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalArithmetic.Scripts
{
    internal class Misollar
    {
        public static char[] amallar = { '+', '-', '*', '/' };
        public List<int> Sonlar(int a, int b)
        {
            List<int> sonlar = new List<int>();
            for (int i = a; i <= b; i++)
            {
                sonlar.Add(i);
            }
            return sonlar;
        }
            Random random = new Random();
        public int RandomSon()
        {
            return random.Next(0, 100);
        }
        public int RandomSonInterval(int x)
        {
            int interval =random.Next(x-20,x+20);
            if (interval != x)
                return interval;
            return RandomSonInterval(x);
        }
        public char RandomAmal()
        {
            return amallar[random.Next(0, amallar.Length)];
        }
        public string RandomElementBtn(List<string> list, string tanlash1, string tanlash2)
        {
            if (list.Contains(tanlash1))
            {
                list.Remove(tanlash1);
                return RandomElementBtn(list, tanlash1,tanlash2);
            }
            if (list.Contains(tanlash2))
            {
                list.Remove(tanlash2);
                return RandomElementBtn(list, tanlash1, tanlash2);
            }
            try { 
            return list[random.Next(0, list.Count)];
            }
            catch { return "63"; }

        }
    }
}
