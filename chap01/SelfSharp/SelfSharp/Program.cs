using System;

namespace SelfSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLineは改行あり　Writeは改行なし
            Console.Write("これは改行なし");
            Console.WriteLine("これは改行あり");
            Console.WriteLine("改行コードも\n使える");

            Console.WriteLine("あなたの名前は？");
            string name = Console.ReadLine();
            Console.WriteLine("こんにちは、{0}さん！",name);
        }
    }
}
