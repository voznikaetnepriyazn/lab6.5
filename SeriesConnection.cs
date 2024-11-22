using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._5
{
    public class SeriesConnection: IResistanse
    {
        public double GetResistanse(List<double> res)
        {
            double total = 0;
            foreach (var items in res)
            {
                total += 1 / items;
            }
            return total;
        }
    }
}
