using System;

namespace ForComma
{
    class Program
    {
        static void Main(string[] args)
        {
            //反復しセクションに複数の文や式を指定出来る
            for (var i = 1; i < 6; Console.WriteLine($"{i}番目のループです。"), i++) ;
            

            for (int i = 1, j = 1; i < 6; i++, j++ ) {
                Console.WriteLine(i * j);
            }
        }
    }
}
