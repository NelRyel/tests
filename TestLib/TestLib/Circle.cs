using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Circle: IAreaCount
    {
        //public double r { get; set; }
        public double r;
        double s;
        public void Count()
        {
            s = Math.PI * Math.Pow(r, 2);
           
        }
        public double GetCount()
        {
            return s  = Math.PI * Math.Pow(r, 2);
        }
    }
}
