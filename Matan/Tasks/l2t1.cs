
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matan.Tasks
{
    public class l2t1 : ICalcData
    {
        public String ProcessInput(object[] data)
        {
            int n = Convert.ToInt32(data[0]);
            return Math.Log(n, 2).ToString();
        }
    }
}
