
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matan.Tasks
{
    public class l3t2 : ICalcData
    {
        public String ProcessInput(object[] data)
        {
            double otv1, otv2, h1, h2, x, y, p1, p2, p3, p4, ab, ah, vb, vh, bel, cher;            
            bel = Convert.ToDouble(data[0]);
            cher = Convert.ToDouble(data[1]);
            ab = Convert.ToDouble((double)bel / (double)(bel + cher));
            ah = Convert.ToDouble((double)(cher + bel - bel) / (double)(bel + cher));
            vb = Convert.ToDouble((double)cher / (double)(bel + cher));
            vh = Convert.ToDouble((double)(cher + bel - cher) / (double)(bel + cher));
            x = (-1) * (ab * (Math.Log(ab, 2))) - (ah * (Math.Log(ah, 2)));
            string ret = $"H(α) = {Math.Round(x, 3)} ";            
            y = (-1) * (vb * (Math.Log(vb, 2))) - (vh * (Math.Log(vh, 2)));
            ret = ret + $"H(β) = {Math.Round(y, 3)} ";
            p1 = Convert.ToDouble((double)(bel - 1) / (double)(cher + bel - 1));
            p2 = Convert.ToDouble((double)cher / (double)(cher + bel - 1));
            p3 = Convert.ToDouble((double)bel / (double)(cher + bel - 1));
            p4 = Convert.ToDouble((double)(cher - 1) / (double)(cher + bel - 1));
            h1 = (-1) * (p1 * (Math.Log(p1, 2))) - (p2 * (Math.Log(p2, 2)));
            h2 = (-1) * (p3 * (Math.Log(p3, 2))) - (p4 * (Math.Log(p4, 2)));
            otv1 = ab * h1 + ah * h2;
            ret = ret + $"H(β/α) = {Math.Round(otv1,3)} ";
            otv2 = otv1 + x - y;
            ret = ret + $"H(α/β) = {Math.Round(otv2,3)} ";
            return ret;
        }
    }
}
