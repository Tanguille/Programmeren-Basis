using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11minmax
    {
        static void Main()
        {
            int[] getallen = { -4, 7, 9, 34, 2, 56, 34, 78 };
            Console.WriteLine(BepaalMinimum(getallen));
            Console.WriteLine(BepaalMaximum(getallen));
        }
        static int BepaalMinimum(int[] getallen)
        {
            int min = int.MaxValue;
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] < min)
                {
                    min = getallen[i];
                }
            }
            return min;
        }
        static int BepaalMaximum(int[] getallen)
        {
            int max = int.MinValue;
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] > max)
                {
                    max = getallen[i];
                }
            }
            return max;
        }
    }
}
