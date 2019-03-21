using ConsoleApplication1.SuperHero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory1();
            Client afClient = new Client(factory);

            afClient.Run();

            //-------------------------------------------

            HeroFactory hfactory = new VoinFactory();
            Hero hero = new Hero(hfactory);

            hero.Hit();
            hero.Run();
        }
    }
}
