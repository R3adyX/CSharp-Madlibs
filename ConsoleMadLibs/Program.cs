using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMadLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var playerWords = new string[9];

            #region User Starting input
            Console.Write("Enter a name: ");
            playerWords[0] = Console.ReadLine();
            Console.Clear(); 
            Console.Write("Enter a friends name: ");
            playerWords[1] = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter a city name: ");
            playerWords[2] = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter a make of a car: ");
            playerWords[3] = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter a plural food: ");
            playerWords[4] = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter a feeling: ");
            playerWords[5] = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter a color: ");
            playerWords[6] = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter a resturant name: ");
            playerWords[7] = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter a type of animal: ");
            playerWords[8] = Console.ReadLine();
            Console.Clear();
            Console.Write("Choose a story 1, or 2: ");
            var storyInput = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            #endregion

            if (storyInput == 1)
            {
                Console.WriteLine($"Once there was a man named {playerWords[0]} and he had a friend named {playerWords[1]}." +
                    $" They lived in a \ncity called {playerWords[2]}," +
                    $"and lived there all thier lifes. They just got a new \njob, but it was too far to walk, so they needed to buy a car.\nThey went to the {playerWords[3]} dealership and got an inexpensive used car.\n" +
                    $"After they went to eat some {playerWords[4]}, and was very {playerWords[5]}! They then looked\nat their new used car and thought {playerWords[6]}" +
                    $" was an ok color.As they drove\naway from {playerWords[7]}, they accidently ran over a large {playerWords[8]}, and got out of there  {playerWords[3]}");
            }
            else
            {
                Console.WriteLine($"We were walking downtown {playerWords[2]} and we smelled some {playerWords[4]}. We got very {playerWords[5]}\n" +
                    $"but we didn't like the place it was being cooked at. it was called {playerWords[7]}.\n" +
                    $"A {playerWords[6]} {playerWords[3]} flew right by me and my bestfriend {playerWords[1]} and the car almost hit a {playerWords[8]},\n" +
                    $"My friend looked at me and said, dam {playerWords[0]} that was a very close call!");
            }
        }
           
               
            

    }
}
