using System;

namespace HelloApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            //DATA TYPES
            /*
            string name = "George";
            int age = 35;
            char grade = 'A';
            double weight = 3.6;
            bool isSmoker = false;

            Console.WriteLine("There was once a man named " + name);
            Console.WriteLine("He was a " + age + " years old");
            Console.WriteLine("He Scored an " + grade);
            Console.WriteLine("He weighed " + weight + " kgs" );
            Console.WriteLine(isSmoker ? "He smokes " : "He doesnt smoke");
            */


            //STRING METHODS 
            /**/
            Console.WriteLine("Girrafe Academy \n is the best says \" Michelle \" ");
            Console.WriteLine("Michelle " + "Njeri");

            string phrase = "C# is cool";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);

            //METHODS
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("cool"));  // returns boolean 
            Console.WriteLine(phrase[0]);
            Console.WriteLine();   



        }
    }
}




