using System;

namespace PAT
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int step = 0;
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    step++;
                }
                else
                {
                    num = (num * 3 + 1) / 2;
                    step++;
                }
            }
            Console.WriteLine(step);
        }
    }
}
