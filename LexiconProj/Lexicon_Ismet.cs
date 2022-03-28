using System;
using System.Collections.Generic;
using System.IO;
namespace LexiconProj
{
    public class Lexicon_Ismet
    {
        // Uppgift 1
        public static void HelloWorld()
        {
            string statement = "Hello World";
            Console.WriteLine(statement);
        }

        // Uppgift 2
        public static void Input()
        {
            Console.Write("Enter first name: ");
            var firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            var secondName = Console.ReadLine();

            Console.Write("Enter age: ");
            var age = Console.ReadLine();

            Console.WriteLine(firstName + " " + secondName + ", " + age);
        }

        // Uppgift 3
        public static void ChangeColour(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        // Uppgift 4
        public static void GetDate()
        {
            var date = DateTime.Now;
            Console.WriteLine(date);
        }

        // Uppgift 5
        public static void GetLargestInt(int a, int b)
        {
            if(a < b)
            {
                Console.WriteLine(b);
            }
            else if(a == b)
            {
                Console.WriteLine("A is equal to B.");
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        // Uppgift 6
        public static void GuessNumber()
        {
            int numOfAttempts = 0;
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int guess = 0;

            while(guess != randomNumber)
            {
                Console.Write("Guess a number between 1 and 100: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if(guess == randomNumber)
                {
                    numOfAttempts++;
                    Console.WriteLine("Correct! The number is " + randomNumber);
                    Console.WriteLine("Number of attempts made: " + numOfAttempts);
                }
                else if(guess < randomNumber)
                {
                    numOfAttempts++;
                    Console.WriteLine("Wrong, try again! The number is higher. ");
                    Console.WriteLine("Number of attempts made: " + numOfAttempts);
                }

                else if (guess > randomNumber){
                    numOfAttempts++;
                    Console.WriteLine("Wrong, try again! The number is lower. ");
                    Console.WriteLine("Number of attempts made: " + numOfAttempts);
                }

            }
          }
        
        // Uppgift 7
        public static void CreateFile()
        {
            Console.WriteLine("Write text below. When finished, press ENTER in order to save the text written in a text file. ");
            var input = Console.ReadLine();
            string path = @"C:\Users\ismocatovic\Desktop\Files\MyTxt.txt";
            using(StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(input);
            }

            // Uppgift 8
            using (StreamReader sr = File.OpenText(path))
            {
                string stream = "";
                while((stream= sr.ReadLine()) != null)
                {
                    Console.WriteLine(stream);
                }
            }

        }

        // Uppgift 9
        public static void PowUppgift()
        {
            Console.Write("Input decimal: ");
            double input = Convert.ToDouble(Console.ReadLine());
            double rotenUr2 = Math.Sqrt(input);
            Console.WriteLine("Result: " + rotenUr2);
        }

        // Uppgift 10

        public static void MultiTabell()
        {
            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t");
                
                for(int j = 1; j <= 10; j++)
                {
                    if (i > 0 && j > 0)
                    {
                        Console.Write(i * j + "\t");
                    }
                    else
                    {
                        Console.Write(j + "\t");
                    }

                }
                Console.Write("\n");
            }
           
          
        }

        // Uppgift 11
        public static void TwoArrays()
        {
            Random rnd = new Random();
            int[] arr = new int[5];
            int tmp;

            // Print unsorted array.

            Console.WriteLine("Unsorted array: ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
                Console.Write(arr[i] + "\t");
            }

            Console.Write("\n");

            for(int i = 0; i < arr.Length; i++)
            {
                
                for( int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
                
            }

            // Sort array from lowest to highest.

            Console.WriteLine("Sorted array asc: ");
            for (int i = 0; i < arr.Length; i++)
            {
              
                Console.Write(arr[i] + "\t");
            }

            
            


            
         

        }

        // Uppgift 12
        public static void CheckPalindrome()
        {

            string input, reverseInput = string.Empty;
            Console.Write("Enter a word: ");
            input = Console.ReadLine().ToUpper();

            for(int i = input.Length -1 ; i >= 0; i--)
            {
                reverseInput += input[i].ToString().ToUpper(); 
                
            }

            if (reverseInput == input)
            {
                Console.WriteLine(input + " is a Palindrome");
            }
            else
            {
                Console.Write(input + " is not a Palindrome. The reversed input is " + reverseInput);
            }
        }


        // Uppgift 13. Note: The first int must always be lower than the second int
        // in order to print out an array between two ints properly.
        public static void PrintArrayBetweenTwoInputNumbers()
        {
            Console.Write("Enter first int: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second int: ");
            int input2 = Convert.ToInt32(Console.ReadLine());               
            
                for (int i = input1 + 1; i < input2; i++)
                {
                    Console.Write(i + "\t");
                }
           }

        // Uppgift 14
        public static void DivideEvenAndOddNumbers()
        {
            Console.WriteLine("Enter a number of integers: ");
            string inputs = Console.ReadLine();
            string[] arr = inputs.Split(",");

            Console.Write("The even numbers are: ");

            foreach(string s in arr)
            {
                int numbers = int.Parse(s);
                if(numbers % 2 == 0)
                {
                    Console.Write(s + " ");
                }
                              
            }

            Console.WriteLine("");

            Console.Write("The odd numbers are: ");
            foreach (string s in arr)
            {
                int numbers = int.Parse(s);
                if (numbers % 2 != 0)
                {
                    Console.Write(s + " ");
                }

            }
          
        }

        // Uppgift 15
        public static void SumInputtedNumbers()
        {
            int numbers, sum = 0;
            Console.WriteLine("Enter a number of integers: ");
            string inputs = Console.ReadLine();
            string[] arr = inputs.Split(",");

            Console.WriteLine("The sum of the following numbers: ");
            foreach (string s in arr)
            {
                numbers = int.Parse(s);
                Console.Write(s + " ");
                sum += numbers;

            }
            Console.WriteLine("");
            Console.WriteLine("is " + sum);

            
        }

        // Uppgift 16
        public static void EnterCharacterNameAndOpponent()
        {
           
            Console.Write("Enter a name for your character: ");
            string characterName = Console.ReadLine();
            Console.Write("Enter a name for your opponent: ");
            string opponentName = Console.ReadLine();

            Random r = new Random();

            int health = r.Next(0, 100);
            int strength = r.Next(0, 100);
            int luck = r.Next(0, 100);

            // Create a new instance of a character.
            Character character = new Character { characterName = characterName, opponentName = opponentName,
                health = health, strength = strength, luck = luck };

            Console.WriteLine("Hello " + characterName + ". Your opponent is " + opponentName);

            Console.WriteLine("Your stats:" + "\n" + "Health: " + health + 
                "\n" + "Strength: " + strength + "\n" + "Luck: " + luck);
        }

        public class Character
        {
            public string characterName { get; set; }

            public string opponentName { get; set; }

            public int health { get; set; }

            public int strength { get; set; }

            public int luck { get; set; }

        }

        static void Main(string[] args)
        {
            
        }
    }
}
