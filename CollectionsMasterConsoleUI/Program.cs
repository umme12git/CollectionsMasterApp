using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var numbers = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //Print the first number of the array
            Console.WriteLine($"The first random number in array numbers is {numbers[0]}");


            //Print the last number of the array)
            Console.WriteLine($"The last random number in array numbers is {numbers[numbers.Length - 1]}");


            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists

            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            ReverseArray(numbers);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers



            Console.WriteLine("-------------------");

            //Sort the array in order now
            //
            Array.Sort(numbers);

            Console.WriteLine("Sorted numbers:");
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List

            var numberList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"Capacity of list numberList is {numberList.Count}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numberList);

            //Print the new capacity
            Console.WriteLine($"The new capacity is {numberList.Count}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int searchNum;
            bool IsNumber;
            do
            {
                Console.WriteLine("Please enter the number you are searching in the number list");
                IsNumber = int.TryParse(Console.ReadLine(), out searchNum);
            } while (IsNumber == false);

            NumberChecker(numberList, searchNum);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results

            OddKiller(numberList);
            //NumberPrinter(numberList);

            Console.WriteLine("Evens Only!!");

            Console.WriteLine("------------------");

            //Sort the list then print results

            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("Sorted Evens!");


            Console.WriteLine("------------------");


            //Convert the list to an array and store that into a variable
            var convertedArr = numberList.ToArray();


            //Clear the list
            numberList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] % 3 == 0)
                    numbers[i] = 0;

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                    numberList.Remove(numberList[i]);

            }
            NumberPrinter(numberList);

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

            if (numberList.Contains(searchNumber))
                Console.WriteLine($"Found number {searchNumber} in the number list");
            else
                Console.WriteLine("Number is not in the number list");

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            while (numberList.Count < 51)
            {

                var num = rng.Next(0, 50);
                numberList.Add(num);



            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            //numbers[0] = rng.Next(0, 50);
            for (int i = 0; i < numbers.Length; i++)
            {
                //Random rng = new Random();
                Console.WriteLine("value of i is " + i);
                numbers[i] = rng.Next(0, 50);
            }

        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
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



