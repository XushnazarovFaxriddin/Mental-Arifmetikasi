using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MentalArithmetic.Scripts
{
    internal class Hisoblash
    {
        public string Eval(String expression)
        {
            DataTable table = new DataTable();
            try
            {
                return table.Compute(expression, String.Empty).ToString();
            }
            catch
            {
                return "TJY";
            }
        }
    }
}
