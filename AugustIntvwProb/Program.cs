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

            //for (int i = 2; i < num / 2; i++)
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

            //*********Print the nth number of a Fibonacci Series 
            //Console.WriteLine("Please enter a number");
            //int userNum = int.Parse(Console.ReadLine());
            //int firstNum = 0;
            //int secondNum = 1;


            //for (int i = 2; i <= userNum; i++)
            //{
            //    int result = firstNum + secondNum;
            //    Console.WriteLine(result);
            //    firstNum = secondNum;
            //    secondNum = result;
            //
            //}

            //********Switch two variable without a temp variable
            //int num1 = 3;
            //int num2 = 5;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //*********Sort an array
            //int[] myArray = { 60, 10, 80, 20, 70, 30, 40, 50 };
            //foreach(int i in myArray)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine();
            //Array.Sort(myArray);
            //foreach(int i in myArray)
            //{
            //    Console.Write(i);
            //}
            //Array.Reverse(myArray);
            //foreach (int i in myArray) Console.Write(i);

            //List all prime numbers
            //Console.WriteLine("Please enter a number");
            //int num = int.Parse(Console.ReadLine());
            //
            //for (int i = 2; i < num; i++)
            //{
            //   // for (int j = 2; j < num - 1; j++)
            //   // {
            //        if (num % i == 0 )
            //        {
            //            break;

            //        }
            //        else if(i == num - 1)
            //        {
            //            Console.WriteLine(i + " is prime.");
            //        }
            //    //}
            //}

            //divide a number without using "/" symbol
            //int num1 = 144;
            //int num2 = 4;
            //int smallerNum = 0;
            //int largerNum = 0;
            //int quotient = 0;

            //if(num1 > num2)
            //{
            //    largerNum = num1;
            //    smallerNum = num2;
            //}
            //else if(num2 > num1)
            //{
            //    largerNum = num2;
            //    smallerNum = num1;
            //}
            //while(quotient * smallerNum != largerNum)
            //{
            //    quotient++;
            //}

            //Console.WriteLine("num 1 / num2  =" + quotient);

            //Find min and max values in an array
            //int[] myArray =  { 74, 85, 37, 95, 84, 46, };
            //int maxVal = 0;
            //int minVal = myArray[0];

            //foreach (var i in myArray)
            //{
            //    if(i > maxVal)
            //    {
            //        maxVal = i;
            //    }
            //}
            //foreach (var i in myArray)
            //{
            //    if(i < minVal)
            //    {
            //        minVal = i;
            //    }
            //}
            //Console.WriteLine("High number is " + maxVal);
            //Console.WriteLine("Low number is " + minVal);

            //Factorial digit sum
            //Console.WriteLine("Please enter a number:");
            //int userNum = int.Parse(Console.ReadLine());
            //int factorialSum = 0;

            //for (int i = userNum - 1; i >= 1; i--)
            //{
            //    userNum = userNum * i;
            //}
            //Console.WriteLine(userNum);

            //int numLength = userNum.ToString().Length;
            //for (int i = 1; i <= numLength; i++)
            //{
            //    factorialSum += userNum % 10;
            //    userNum = userNum / 10;
            //}
            //Console.WriteLine(factorialSum);

            //Smallest multiple of all numbers 1 - 20
            //bool isMultiple = false;
            //int i = 20;
            //while (isMultiple == false)
            //{
            //    i++;

            //    if (i % 2 == 0 && i % 3 == 0 && i % 5 == 0 && i % 7 == 0 && i % 11 == 0 && i % 13 == 0 && i % 17 == 0 && i % 19 == 0)
            //    {
            //        isMultiple = true;
            //        Console.WriteLine(i);

            //    }
            //}     
            //Console.WriteLine(i);

            //Merge two arrays
            //int[] myArr = {1,2,3,4 };
            //string[] myArr2 = { "a", "b", "c", "d", };
            //string[] myArr3 = new string[4];
            //for (int i = 0; i < myArr3.Length; i++)
            //{
            //    myArr3[i] = myArr[i] + myArr2[i];
            //}
            //foreach (var item in myArr3)
            //{
            //    Console.WriteLine(item);
            //}

            //653xy
            for (int i = 65300; i < 65400; i++)
            {
                if (i % 80 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadKey();
        }
    }
}
