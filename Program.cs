using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSTeamCollaborationTool
{
    class Program
    {
        public static int SumX(int x, int N)
        {
            int hasil = 0;
            if (x < -1000 || x > 1000 || N < -1000 || N > 1000)
            {
                Console.WriteLine("Sorry, The Number Limit");
            }
            else
            {
                if (x < 0 && N >= 0)
                {
                    hasil = 0;
                }
                else if (x > 0 && N <= 0)
                {
                    hasil = 0;
                }
                else if (x == 0)
                {
                    hasil = 0;
                }
                else if (x >= 0 && N >= 0)
                {
                    int temp = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        if (i % x == 0)
                        {
                            temp += i;
                        }
                    }
                    hasil = temp;
                }
                else if (x < 0 && N < 0)
                {
                    int temp = 0;
                    for (int i = 1; i <= N * -1; i++)
                    {
                        if (i % x * -1 == 0)
                        {
                            temp += i;
                        }
                    }
                    hasil = temp * -1;
                }
            }
            return hasil;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("sumX(3, 10): " + (SumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (SumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (SumX(0, 10) == 0));
            Console.WriteLine("sumX(-1, 10): " + (SumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (SumX(-1, -10) == -55));
        }
    }
}
