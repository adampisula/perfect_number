using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            for (decimal j = 2; j < decimal.MaxValue; j += 2)
            {
                if (perf(j) == true)
                {
                    Console.WriteLine(j);

                    //Console.Read();
                
                }
                else
                    continue;
            }
        }

        static bool perf(decimal a)
        {
            List<decimal> dividors = new List<decimal>();
            decimal sum = 0;

            if (a % 2 == 0)
            {
                for (int i = 1; i < a / 2 + 1; i++)
                {
                    if (a % i == 0)
                    {
                        dividors.Add(i);
                    }
                    else
                    {
                        continue;
                    }
                }

                for (int j = 0; j < dividors.Count; j++)
                {
                    sum += dividors[j];
                }

                dividors.Clear();

                if (sum == a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
