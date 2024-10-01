using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Triangle : IAreaCount
    {
       public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }


        public void Count()
        {
            //Sqrt(double value): возвращает квадратный корень числа value
            double s = 0;
            double p = (a + b + c) / 2;

            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //public void TT()
        //{

        //    if(Math.Pow(c,2)==Math.Pow(a,2) + Math.Pow(b, 2)|| Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)|| Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
        //    {
                
        //    }

        //}


        public double GetCount()
        {
            
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
