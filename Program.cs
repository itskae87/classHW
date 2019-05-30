using System;

namespace classes
{
    class Program
    {

        static void Main(string[] args)
         {
            //instance of SuperPerson class called SP1
            SuperPerson SP1 = new SuperPerson("Spiderguy", 75);
            SP1.SuperPowerName("Spider Sensibilities");
            SuperPerson SP2 = new SuperPerson("El Bado Asso", 80);
            SP2.SuperPowerName("Badserrry");

        } 
            //new class
            public class SuperPerson
        {
            //SuperPerson's properties
            public static string _name { set; get; }
            public static int _HP { set; get; }

            //the constructor
            public SuperPerson(string name, int HP)
            {
                _name = name;
                _HP = HP;
                Console.WriteLine("SuperPerson created!");
                Console.WriteLine("SuperPerson name is {0}", name);
                Console.WriteLine("{0}'s hitpoints are: {1}", name, HP);
            }
            public void SuperPowerName(string pName)
        {
            Console.WriteLine("Your super power is {0}", pName);
        }

            public void SuperSaucer(string rest)
            {
                Console.WriteLine("Lets take a day off as superhero {0)", rest);
            }


        }
    }
}
