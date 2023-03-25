using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Random rand = new Random();

            float health1 = rand.Next(50, 100);
            int damage1 = rand.Next(30, 67);
            int armor1 = rand.Next(59, 89);

            float health2 = rand.Next(100, 120);
            int damage2 = rand.Next(50, 80);
            int armor2 = rand.Next(40, 87);
            Console.WriteLine($"Гладитатор 1- здоровье {health1} ,атака  {damage1} , броня {armor1}");
            Console.WriteLine($"Гладитатор 2- здоровье {health2} ,атака  {damage2} , броня {armor2}");
            Console.WriteLine("Начинаеться бой");

            while (health1 > 0 && health2 > 0)
            {
                health1 -=Convert.ToSingle (rand.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) / 100 * armor2;


                Console.WriteLine("Здоровье 1 гладиатора" + health1);
                Console.WriteLine("Здоровье 2 гладиатора" + health2);


            }
            if (health1 < 0 && health2 < 0)
            {

                Console.WriteLine("Ничья");
            }
            else if (health2<0)
            {

                Console.WriteLine("2 Гладиатор победил");
            }
            else if(health1<0)
            {

                Console.WriteLine(" 1 Гладиатор победил");
            }
            return;



        }

    }
}
