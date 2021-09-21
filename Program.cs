/*
 Author: Colin Bauer
 Date: 9/21/2021
 Comments: Creatinmg a conversion tool for KM to M. This tool is being created 
 for Tech Project #3
 
 */

using System;

namespace Tech_Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a KM-Increment value in integer form! Please enter q to exit the program");
            bool Repeat = true;
            while (Repeat)
            {
                try
                {
                    int KM = 0;
                    string UserInput = Console.ReadLine();

                    if (String.Equals("q", UserInput.ToLower()))
                    {
                        System.Environment.Exit(0);
                    }

                    Double C = 0.6213171;
                    KM = int.Parse(UserInput);

                    if ((KM > 10) && (KM < 25))
                    {
                        int N = 0;

                        Console.WriteLine("Kilometer Increment Value =" + KM);
                        Console.WriteLine("Kilometers" + "\t" + "Equiv Miles");


                        while (N * KM < 200)
                        {
                            Console.WriteLine(N * KM + "\t"+"\t" + N * KM * C);
                            N++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter any integer value between 10 and 25");
                    }

                }
                catch
                {
                    Console.WriteLine("Enter any integer value between 10 and 25 or Enter q to exit");
                }
            }
        }
    }
}
