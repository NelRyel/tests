using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib.ili_tak
{
    public class AreaCounter
    {
        private double s;
        private string type;
        private void CountArea(object o)
        {
            
       
            if(o is Triangle t)
            {
                double p = (t.a + t.b + t.c) / 2;
                s = Math.Sqrt(p * (p - t.a) * (p - t.b) * (p - t.c));
                type = t.GetType().Name;
                if (Math.Pow(t.c, 2) == Math.Pow(t.a, 2) + Math.Pow(t.b, 2) || Math.Pow(t.a, 2) == Math.Pow(t.b, 2) + Math.Pow(t.c, 2) || Math.Pow(t.b, 2) == Math.Pow(t.a, 2) + Math.Pow(t.c, 2))
                {
                    type += " равнобедренный";
                }
                return;
               
            }
            if(o is Circle c)
            {

                s = Math.PI * Math.Pow(c.r, 2);
                type = c.GetType().Name;

                return;
            }

            
        }

        public void GetAreaCount(object o)
        {
            CountArea(o);
            Console.WriteLine(type);
            Console.WriteLine(s);
        }
    }
}
