using System;
using System.Linq;

namespace MyOmikujiCli
{
    class Program
    {

        private static readonly string[] FORTUNES = {
            "大吉",
            "吉",
            "中吉",
            "小吉",
            "末吉",
            "凶",
            "大凶",
        };

        private static readonly string[] LUCKY_ITEMS = {
            "なし",
            "ベルト",
            "青ペン",
            "iPhone",
            "ビデオテープ",
        };
        static void Main(string[] args)
        {
            var fortune = FORTUNES.OrderBy((_) => { return Guid.NewGuid(); }).First();
            var luckyItem = LUCKY_ITEMS.OrderBy((_) => { return Guid.NewGuid(); }).First();
            
            Console.WriteLine($"あなたの運勢は、{fortune}!ラッキーアイテムは{luckyItem}!");
        }
    }
}
