﻿using System;

namespace IterationFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.
            int counter = 0;
            for (int i = 1; i <= 100;i++){
                if(i%3==0){
                    counter++;
                }
            }
            //Console.WriteLine(string.Format("Numbers that are divisible by 3 are : {0}", counter));

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.
            var sum = 0;
            while(true){
                Console.WriteLine("Enter a number or \"ok\" to exit");
                var input = Console.ReadLine().ToLower();
                if (input.Equals("ok"))
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine(string.Format("The total sum : {0}",sum));
        }
    }
}
