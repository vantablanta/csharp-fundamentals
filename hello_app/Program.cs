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
            /*
                Console.WriteLine("Girrafe Academy \n is the best says \" Michelle \" ");
                Console.WriteLine("Michelle " + "Njeri");

                string phrase = "C# is cool";
                Console.WriteLine(phrase);
                Console.WriteLine(phrase.Length);

                //METHODS
                Console.WriteLine(phrase.ToUpper());
                Console.WriteLine(phrase.Contains("cool"));  // returns boolean 
                Console.WriteLine(phrase[0]);
                Console.WriteLine(phrase.Substring(5,2));   
             */


            // NUMBER METHODS 
            /*
                int num = 6;
                Console.WriteLine(5 / 2);
                Console.WriteLine(num);
                num++;
                Console.WriteLine(num);

                //METHODS
                Console.WriteLine(Math.Abs(-40));
                Console.WriteLine(Math.Pow(8, 2));
                Console.WriteLine(Math.Sqrt(64));
                Console.WriteLine(Math.Max(50, 454)); //takes only 2 arguments
                Console.WriteLine(Math.Round(4.99));
             */

            //GETTING USER INPUT 
            /*
                Console.Write("Enter Name: ");
                string? inputName  = Console.ReadLine();
                Console.WriteLine("Hello" + inputName);
             */


            // CALCULATOR APP

            // CONVERTING STRING TO NUMBER 
            /*
                string num = "43";
                int convertedNum = Convert.ToInt32(num);
                Console.WriteLine(convertedNum);
             */


            /*
                Console.Write("Enter first number: ");
                double firstInput = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number");
                double secondInput = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Sum of your numbers is : " + (firstInput + secondInput));

                Console.ReadLine();
            */

            // MADLIBS GAME 

            /*
                string? color, pluralNoun, celebrityName;

                Console.Write("Enter favourite color: ");
                color = Console.ReadLine();
                color?.ToLower();

                Console.Write("Enter a plural noun: ");
                pluralNoun = Console.ReadLine();
                pluralNoun?.ToLower();

                Console.Write("Enter celebrity name: ");
                celebrityName = Console.ReadLine();
                celebrityName?.ToLower();

                Console.WriteLine("Here is your madlib! enjoy");
                Console.WriteLine("______");
                Console.WriteLine($"Roses are {color}");
                Console.WriteLine($"{pluralNoun} are blue ");
                Console.WriteLine($"I love {celebrityName}"); 
             */


            // ARRAYS 
            /**/











            Console.ReadLine();

        }
    }
}




