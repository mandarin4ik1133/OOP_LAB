using System;

namespace SyntaxLab
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
        }

        //№1
        private static void Task1()
        {
            int userAge = 55;                   
            string userName = "Артем";         

            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + userAge);
        }

        //№2
        private static void Task2()
        {
            int @int = 10;                      
            string @class = "Hello";   

            Console.WriteLine("int = " + @int + ", class = " + @class);
        }

        //№3
        private static void Task3()
        {
            string name = "Анна";

            
            int age = 82;

            Console.WriteLine("Привіт, " + name + "! Твій вік: " + age);
        }
    }
}
