using System;
using System.Globalization;

namespace StrLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //8文字
            var str1 = "ABCアイウエオ";
            //全角文字も1文字としてカウントされる
            Console.WriteLine(str1.Length); //結果:8
            //2文字
            var str2 = "叱る"; 
            Console.WriteLine(str2.Length);  //結果:2
            //2文字 (サロゲートペア：𠮟)
            var str3 = "𠮟る";
            Console.WriteLine(str3.Length); //結果:3
            

            //サロゲートペアの判定
            Console.WriteLine(Char.IsSurrogate(str3[0])); //結果:TRUE

            //StringInfoクラスを使う事でサロゲートペアを含んだ文字列を正しくカウント出来る。
            StringInfo strInfo = new StringInfo(str3);
            Console.WriteLine(strInfo.LengthInTextElements); //結果:2

        }
    }
}
