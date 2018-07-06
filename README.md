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
