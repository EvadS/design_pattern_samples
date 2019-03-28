using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot(); // делаем выстрел, осталось 9 патронов
            GameHistory game = new GameHistory();

            game.History.Push(hero.SaveState()); // сохраняем игру

            

            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            hero.RestoreState(game.History.Pop());

            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            Console.Read();
        }
    }
}
