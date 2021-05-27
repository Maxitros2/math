using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matan.Tasks
{
    public class l4t1 : ICalcData
    {
        public string ProcessInput(object[] data)
        {
            int len = Convert.ToInt32(data[0]);
            A ob = new A();
            ob.P1 = new double[len];
            Dictionary<char, double> valuePairs = new Dictionary<char, double>();
            ob.Alpha = new char[len];
            ob.Res = new string[len];
            for (int i = 0; i<len; i++)
            {
                ob.P1[i] = Convert.ToDouble(data[i+1]);
                ob.Alpha[i] = Convert.ToChar(data[i + 1 + len]);
                valuePairs.Add(ob.Alpha[i], ob.P1[i]);
            }            
            ob.Sort();
            ob.Fano(0, len-1);
            string ret = "";
            for (int i = 0; i < len; i++)
            {
                ret=ret+" "+ob.Alpha[i] + ":" + ob.Res[i];
            }
            ret = ret + " | ";
            double l1 = 0d;
            for (int i = 0; i < len; i++)
            {
                double ver = 0;
                valuePairs.TryGetValue(ob.Alpha[i], out ver);
                l1 = l1 + ver * ob.Res[i].Length;
            }
            ret = ret + $"L={l1} ";
            double l2 = 0d;
            for (int i = 0; i < len; i++)
            {
                double ver = 0;
                valuePairs.TryGetValue(ob.Alpha[i], out ver);
                if (ver == 0)
                    continue;
                l2 = l2 + ver * Math.Log(ver, 2);
            }
            l2 = -l2;
            ret = ret + $"H={l2} ";
            ret = ret + $"R={1d-l2/l1} ";
            return ret;
        }
    }
    public class A
    {

        public double[] P1 = { 1d / 8d, 1d / 8d, 1d / 2d, 0, 1d / 4d };
        public char[] Alpha = { 'a', 'b', 'd', 'g', '_' };

        public string[] Res = new string[5];

        double schet1 = 0;
        double schet2 = 0;


        public void Sort()
        {
            for (int i = 0; i < P1.Length; i++)
            {
                for (int j = 0; j < P1.Length - i - 1; j++)
                {
                    if (P1[j] < P1[j + 1])
                    {
                        char temp2;
                        double temp1 = 0;
                        temp1 = P1[j];
                        temp2 = Alpha[j];
                        P1[j] = P1[j + 1];
                        Alpha[j] = Alpha[j + 1];
                        P1[j + 1] = temp1;
                        Alpha[j + 1] = temp2;

                    }
                }
            }


        }
        int m;

        public int Delenie_Posledovatelnosty(int L, int R)
        {

            schet1 = 0;
            for (int i = L; i <= R - 1; i++)
            {
                schet1 = schet1 + P1[i];
            }

            schet2 = P1[R];
            m = R;
            while (schet1 >= schet2)
            {
                m = m - 1;
                schet1 = schet1 - P1[m];
                schet2 = schet2 + P1[m];
            }
            return m;


        }
        int g = 0;

        public void Fano(int L, int R)
        {
            int n;

            if (L < R)
            {

                n = Delenie_Posledovatelnosty(L, R);
                Console.WriteLine(n);
                for (int i = L; i <= R; i++)
                {
                    if (i <= n)
                    {
                        Res[i] += Convert.ToByte(0);
                    }
                    else
                    {
                        Res[i] += Convert.ToByte(1);
                    }
                }



                Fano1(L, n);

                Fano(n + 1, R);

            }


        }

        public void Fano1(int L, int R)
        {
            int n;

            if (L < R)
            {

                n = Delenie_Posledovatelnosty(L, R);
                Console.WriteLine(n);
                for (int i = L; i <= R; i++)
                {
                    if (i <= n)
                    {
                        Res[i] += Convert.ToByte(0);
                    }
                    else
                    {
                        Res[i] += Convert.ToByte(1);
                    }
                }

                Fano(L, n);

                Fano1(n + 1, R);

            }


        }        

    }
}
