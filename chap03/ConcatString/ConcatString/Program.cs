using System;

namespace ConcatString
{
    class Program
    {
        static void Main(string[] args)
        {
            //+演算子の文字列の結合は　str3 = str1 + str2 で三つの固定の文字列のインスタンスが生成されるので
            //効率悪くてやばいらしい
            Console.WriteLine("Start");
            var result = "";
            for (int i = 0; i < 100000; i++) result += "いろは";
            Console.WriteLine("End");
        }
    }
}
