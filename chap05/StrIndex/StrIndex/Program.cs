using System;
using System.Linq;


namespace StrIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            //文字列の検索
            var str = "にわにはにわにわとりがいる";
            //IndexOf       前方から検索
            //LastIndexOf   後方から検索
            Console.WriteLine(str.IndexOf("にわ")); //結果：0
            Console.WriteLine(str.IndexOf("にも")); //結果:-1 (見当たらない)
            Console.WriteLine(str.LastIndexOf("にわ")); //結果:6
            Console.WriteLine(str.IndexOf("にわ",1)); //1文字目（先頭は0文字目）から検索 結果:4
            Console.WriteLine(str.LastIndexOf("にわ", 1)); //1文字目（先頭は0文字目）から前方に向かって検索　結果:0
            Console.WriteLine(str.IndexOf("にわ",2,5)); //2文字目から2+5文字目まで範囲で検索　結果:4
            Console.WriteLine(str.LastIndexOf("にわ", 5, 3)); //後方からなので範囲の指定も後ろを先に指定する。 5文字目から5-3文字目までの範囲で検索
            //Console.WriteLine(str.IndexOf("にわ", 5, 10));            //範囲の指定が文字列を超えるとエラー 5+10 = 15文字目は存在しない。


            //特定の文字列が含まれるかの判定
            Console.WriteLine(str.Contains("にわとり")); //True
            Console.WriteLine(str.StartsWith("にわとり")); //False
            Console.WriteLine(str.StartsWith("にわ")); //True
            Console.WriteLine(str.EndsWith("にわ")); //False
            Console.WriteLine(str.EndsWith("いる")); //True

            //条件を満たした文字が含まれるかの判定
            //strに入っている文字列を1文字ずつchに入れて10進数の数値であるかの判定を行う。
            //Anyの場合、戻り値は一つでもTrueであればTrueを返す。
            Console.WriteLine(str.Any(ch => Char.IsDigit(ch))); //False
            var str2 = "あいおえお9かきくけこ";
            Console.WriteLine(str2.Any(ch => Char.IsDigit(ch))); //True
            //Allの場合、全てTrueの時のみTrueを返す
            Console.WriteLine(str2.All(ch => Char.IsDigit(ch))); //False
            var str3 = "123456789";
            Console.WriteLine(str3.All(ch => Char.IsDigit(ch))); //True



            //文字の抜出し
            Console.WriteLine(str.Substring(5, 2));  //5文字目から2文字抜きだす
            Console.WriteLine(str[0]);  //1文字だけなら要素を指定
            foreach (var c in str)
            {
                Console.WriteLine(c);
            }





        }
    }
}
