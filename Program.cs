using System.Security.Cryptography;

namespace Krokodillespillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Krokodillespillet");
            Console.WriteLine("Bruk \"<\", \">\" eller \"=\"");
            Console.WriteLine("");
            var points = 0;
            while (true)
            {
                var randomNumber1 = RandomNumber();
                var randomNumber2 = RandomNumber();
                Console.WriteLine(randomNumber1 + " _ " + randomNumber2);
                var userResponse = Console.ReadLine();

                if (userResponse == ">")
                {
                    if (randomNumber1 > randomNumber2)
                    {
                        points++;
                        Console.WriteLine("Korrekt!" + " Poeng: " + points);
                    } else if (randomNumber1 < randomNumber2)
                    {
                        points--;
                        Console.WriteLine("Feil!" + " Poeng: " + points);
                    }
                    else
                    {
                        points--;  
                        Console.WriteLine("Feil!" + " Poeng: " + points);
                    }
                }

                if (userResponse == "=")
                {
                    if (randomNumber1 == randomNumber2)
                    {
                        points++;
                        Console.WriteLine("Korrekt!" + " Poeng: " + points);
                    }
                    else if (randomNumber1 < randomNumber2)
                    {
                        points--;
                        Console.WriteLine("Feil!" + " Poeng: " + points);
                    }
                    else
                    {
                        points--;
                        Console.WriteLine("Feil!" + " Poeng: " + points);
                    }
                }

                if (userResponse == "<")
                {
                    if (randomNumber1 < randomNumber2)
                    {
                        points++;
                        Console.WriteLine("Korrekt!" + " Poeng: " + points);
                    }
                    else if (randomNumber1 == randomNumber2)
                    {
                        points--;
                        Console.WriteLine("Feil!" + " Poeng: " + points);
                    }
                    else
                    {
                        points--;
                        Console.WriteLine("Feil!" + " Poeng: " + points);
                    }
                }

                //if ()
                //{
                //    randomNumber1 < randomNumber2
                //}
            }
        }

        //private static int pointCounter()
        //{
        //    var points = 0;
        //    return points;
        //}

        public static int RandomNumber()
        {
            var randomNum = new Random();
            return randomNum.Next(0, 12);
        }
    }
}