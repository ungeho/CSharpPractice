using System;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            goto THERE;
            Console.WriteLine("ここはスキップ");
            THERE:
            Console.WriteLine("スキップしました");
            //ネストされたループから脱出する場合
            //switch命令で特定のラベルに移動したい場合に使用

            var rank = "甲";

            switch(rank)
            {
                case "甲":
                    Console.WriteLine("大変良いです。");
                    goto case "丙";
                case "乙":
                    Console.WriteLine("良いです。");
                    goto case "丙";
                case "丙":
                    Console.WriteLine("合格です。");
                    break;
                case "丁":
                    Console.WriteLine("頑張りましょう。");
                    break;
                default:
                    Console.WriteLine("？？？");
                    break;
            }

        }
    }
}
