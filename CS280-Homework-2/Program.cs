using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            Console.Write("請輸入寶可夢編號:");
            try
            {
                pokemon.Number = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("須輸入數字，請重新執行程式");
                return;
            }
            Console.WriteLine("請輸入寶可夢名稱:");
            try
            {
                pokemon.Name = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("須輸入文字，請重新執行程式");
                return;
            }
            Console.WriteLine("請輸入寶可夢身高(單位/尺):");
            try
            {
                pokemon.Height = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("須輸入數字，請重新執行程式");
                return;
            }
            Console.WriteLine("請輸入寶可夢體重(單位/磅):");
            try
            {
                pokemon.Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("須輸入數字，請重新執行程式");
                return;
            }
            Console.WriteLine("請輸入寶可夢技能:");
            try
            {
                pokemon.Abilities = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("須輸入文字，請重新執行程式");
                return;
            }
            Console.WriteLine("請輸入寶可夢種類:");
            try
            {
                pokemon.Categroy = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("須輸入文字，請重新執行程式");
                return;
            }
            Console.WriteLine("請輸入寶可夢性別:");
            try
            {
                pokemon.Gender = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("須輸入文字，請重新執行程式");
                return;
            }
            Console.WriteLine(
                @"你所輸入的寶可夢資料：
編號:#{0},
名稱:{1},
身高:{2}尺,
體重:{3}磅,
技能:{4},
種類{5},
性別:{6},
請按任意鍵退出",
                pokemon.Number, pokemon.Name, pokemon.Height, pokemon.Weight,
                pokemon.Abilities, pokemon.Categroy, pokemon.Gender);
        }
    }
}