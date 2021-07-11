using System;

namespace StrEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            //文字列の判定
            var str1 = "";
            var str2 = "     ";
            //null　または　""であればTrue
            Console.WriteLine(String.IsNullOrEmpty(str1)); //結果:True
            Console.WriteLine(String.IsNullOrEmpty(str2)); //結果:False
            //null または　"" または　"     "であればTrue
            Console.WriteLine(String.IsNullOrWhiteSpace(str2)); //結果:True
        }
    }
}
