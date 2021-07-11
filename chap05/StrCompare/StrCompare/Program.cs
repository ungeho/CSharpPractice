using System;
using System.Globalization;

namespace StrCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "wings";
            var str2 = "WINGS";
            //大文字小文字の区別を無視して比較
            Console.WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase));           //結果:True
            //上と等価　戻り値は　str1==str2 のとき 0 , str1>str2 のとき 正数 , str<str2 のとき 負数
            Console.WriteLine(String.Compare(str1,str2, StringComparison.OrdinalIgnoreCase));   //結果:0

            var full = "ＷＩＮＧＳ";
            var half = "WINGS";

            //現在の地域情報に基づいて文字列比較ルールを取得
            var ci = CultureInfo.CurrentCulture.CompareInfo;
            //文字列の比較
            Console.WriteLine(ci.Compare(full,half));
            //文字列の比較　ルール：全角半角の違いを無視
            Console.WriteLine(ci.Compare(full,half,CompareOptions.IgnoreWidth));　//結果:0


            var hiragana = "あいうえお";
            var katakana = "アイウエオ";


            //文字列の比較
            Console.WriteLine(ci.Compare(hiragana, katakana)); 
            //文字列の比較　ルール：ひら/カナの違いを無視
            Console.WriteLine(ci.Compare(hiragana, katakana, CompareOptions.IgnoreKanaType)); //結果:0




        }
    }
}
