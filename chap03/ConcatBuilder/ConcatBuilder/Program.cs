using System;
using System.Text;

namespace ConcatBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            //StringBuilderは可変長の文字列である為,文字列の連結でもインスタンスの生成や破棄が頻繁に発生しない。
            //最初に確保した一定のサイズを超えたら文字列サイズを2倍に拡張する。その際にメモリの再割り当てが起こる為、文字数がある程度想定出来ている場合は以下のように宣言する。
            //var builder = new StringBuilder(1000);
            var builder = new StringBuilder();
            for (int i = 0; i < 100000; i++) builder.Append("いろは");
            var result = builder.ToString();
            Console.WriteLine("End");

        }
    }
}
