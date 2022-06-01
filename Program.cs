using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string worck;
            string zodiak;
            string height;

            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            age = Console.ReadLine();
            Console.WriteLine("Кем вы работайте?");
            worck = Console.ReadLine();
            Console.WriteLine("Какой у вас знак зодиака?");
            zodiak = Console.ReadLine();
            Console.WriteLine("какого вы роста?");
            height = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} лет, вы {worck} со знаком зодиака {zodiak}, и ваш рост {height}.");
            Console.WriteLine("Конец!");
        }

        
    }
}
