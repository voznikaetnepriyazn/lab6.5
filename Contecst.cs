using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._5
{
    /*public class Contecst
    {
        public List<double> res { get; set; }
        private IResistanse ires;
        public Contecst(IResistanse ires, List<double> res)
        {
            this.res = res;
            this.ires = ires;
        }
        public double AtGetResistanse(List<double> res)
        {
            foreach(var item in res)
            {
                if (item <= 0) 
                {
                    throw new ArgumentException("нельзя отрицательное");
                }
            }
            return res[0];
        }
    }*/
    public class ResistanceSender
    {
        public List<double> res;
        IResistanse resistanse;
        public ResistanceSender(IResistanse resistanse)
        {
            this.resistanse = resistanse ?? throw new ArgumentNullException(nameof(resistanse)); ;
        }
        public void ProcessResistance()
        {
            this.resistanse.GetResistanse(res);
        }
    }
}
