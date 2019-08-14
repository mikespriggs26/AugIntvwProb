using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustIntvwProb
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check to see if a number is a palindrome.
            //Console.WriteLine("Please enter a number:");
            //string num1 = Console.ReadLine();
            //string num2 = "";


            //for (int i =  num1.Length - 1; i >= 0; i--)
            //{
            //    num2 += num1[i];
            //}
            //if(num1 == num2)
            //{
            //    Console.WriteLine("Your number is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is not a palindrome.");
            //}
            //Console.ReadKey();  
            //*********************************************************


            //Eliminate duplicate letters from a string
            //Console.WriteLine("Please enter a word: ");
            //string str = Console.ReadLine();
            //string newStr = "";

            //foreach(char j in str)
            //{
            //    if (newStr.Contains(j) == false)       //Could have used (!newStr.Contains(j))
            //    {
            //        newStr += j;
            //    }
            //}
            //Console.WriteLine(newStr);
            //Console.ReadKey();

            //List all Armstrong Numbers
            //for (int i = 100; i < 101; i++)
            //{
            //    int num1 = i % 10;  //isolates the 3rd digit
            //    int num2 = i / 10;  //isolates the 1st and 2nd digit for use in the next 2 calculations
            //    int num3 = num2 % 10;   //isolates the 2nd number
            //    int num4 = i / 100;     //isolates the 1st number
            //    Console.WriteLine(num1);
            //    Console.WriteLine(num3);
            //    Console.WriteLine(num4);

            //    int sum = num1 * num1 * num1 * num3 * num3 * num3 * num4 * num4 * num4;
            //    Console.WriteLine(sum);
            //    if(sum == i)
            //    {
            //        Console.WriteLine(i + " is an Armstrong Number!");
            //    } 
            //}

            //Determine if a number is prime
            //Console.WriteLine("please enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 2; i < num; i++)
            //{

            //    if (num % i == 0)
            //    {
            //        Console.WriteLine("your number is NOT prime.");
            //        break;
            //    }

            //    else if (i == num - 1)
            //    {
            //        Console.WriteLine("Your number is prime.");
            //    }
            //}

            //Find the largest number in an array
            //int[] myArray = { 60, 10, 20, 30, 40, 50 };
            //int highestNum = 0;

            //foreach (int i in myArray)
            //{
            //    if(i > highestNum)
            //    {
            //        highestNum = i;
            //    }
            //}
            //Console.WriteLine(highestNum);

            //Print the nth number of a Fibonacci Series 
            Console.WriteLine("Please enter a number");
            int userNum = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;
            

            for (int i = 2; i <= userNum; i++)
            {
                int result = firstNum + secondNum;
                Console.WriteLine(result);
                firstNum = secondNum;
                secondNum = result;

            }


            Console.ReadKey();
        }
    }
}
