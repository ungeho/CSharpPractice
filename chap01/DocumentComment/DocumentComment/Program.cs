using System;

namespace DocumentComment
{
    //ドキュメンテーションコメントは通常,タグでマークアップする。
    //ドキュメンテーションコメントに書く内容は概要や仕様。
    //ドキュメンテーションコメントに書いた内容はインテリセンスのツールヒントとして表示される。
    //表示 -> オブジェクトブラウザにも反映される。
    /// <summary>
    /// 人物の情報を表す
    /// </summary>
    class Person
    {
        /// <summary>
        /// 人物の苗字
        /// </summary>
        public string firstName;

        /// <summary>
        /// 人物の名前
        /// </summary>
        public string lastName;


        /// <summary>
        /// 氏名を表示する
        /// </summary>
        /// <param name="age"></param>
        /// <returns>氏名と年齢に基づいて整形された文字列</returns>
        public string Show(int age)
        {
            return $"名前は{lastName} {firstName}、{age}歳です。";
        }

        static void Main(string[] args)
        {
            var p = new Person();
            Console.Write("苗字を入力してください：");
            p.firstName = Console.ReadLine();
            Console.Write("名前を入力してください：");
            p.lastName = Console.ReadLine();
            Console.Write("年齢を入力してください：");
            //int.Perseはユーザーの入力した整数を読み込む
            Console.WriteLine(p.Show(int.Parse(Console.ReadLine())));
        }
    }
}
