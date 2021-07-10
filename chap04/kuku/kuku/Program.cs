using System;

namespace kuku
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}\t",i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
