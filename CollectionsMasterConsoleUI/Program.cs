using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var nums = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            //Array = Populater(Array);
            Populater(nums);

            //TODO: Print the first number of the array
            Console.WriteLine(nums[0]);

            //TODO: Print the last number of the array    
            Console.WriteLine(nums[nums.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(nums);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            nums.Reverse();
            NumberPrinter(nums);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(nums);
            NumberPrinter(nums);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(nums);
            NumberPrinter(nums);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            //var sorted = Array.OrderBy(x => x);
            Array.Sort(nums);
            NumberPrinter(nums);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var list = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"{list.Count}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(list);

            //TODO: Print the new capacity
            Console.WriteLine($"{list.Count}");


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string search = Console.ReadLine();
            if (int.TryParse(search, out int ideal) == true)
            {
                NumberChecker(list, int.Parse(search));
            } else
            {
                Console.WriteLine($"{search} is not in the list");
            }
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(list);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(list);
            NumberPrinter(list);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var converter = list.ToArray();

            //TODO: Clear the list
            list.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    //numberList.Remove(numberList[i]);
                    numberList.RemoveAt(i);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool success = false;
            foreach (var num in numberList)
            {
                if (num == searchNumber) success = true;
            }
            if (success == true)
            {
                Console.WriteLine($"{searchNumber} is in the list!");
            } else
            {
                Console.WriteLine($"{searchNumber} is not in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random r = new Random();
            int rng = 0;
            for (int i = 0; i < 50; i++)
            {
                rng = r.Next(0, 50);
                numberList.Add(rng);
            }
        }

        private static void Populater(int[] numbers)
        {
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            var Array = numbers;
            Random r = new Random();
            int rng = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                rng = r.Next(0, 50);
                Array[i] = rng;
            }
            //return Array;
        }        

        private static void ReverseArray(int[] array)
        {
            var flip = new int[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                flip[i] = array[(array.Length - 1) - i];
            }
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = flip[i];
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
