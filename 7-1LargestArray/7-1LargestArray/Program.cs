using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1LargestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //create random instance and declare variables
            Random rand = new Random();
            int rows;
            int cols;
            double count1 = 0;
            const int randMin = 0;
            const int randMax = 101;

            //request user input of rows and columns
            Console.WriteLine("Enter number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());

            //create multi array with random ints
            int[,] intarray = new int[rows, cols];
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        intarray[i, j] = rand.Next(randMin, randMax);
                        Console.WriteLine("intarray[{0},{1}] = {2}", i, j, intarray[i, j]);
                        count1++;
                    }
                }
            };
            //search for max value
            int maxNum = 0;
            int index1 = 0;
            int index2 = 0;
            double count2 = 0;
            

            for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        
                        if (intarray[i,j] > maxNum)
                        {
                            maxNum = intarray[i,j];
                            index1 = i;
                            index2 = j;
                        } //end of if
                    }//end of inner for
                }//end of outer for

            Console.WriteLine("Max value is {0}", maxNum);
            Console.WriteLine("Your Max Value is found at index(es): ");

            //loop again for maxNum in other indexes
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (intarray[i, j] == maxNum )
                    {
                        index1 = i;
                        index2 = j;
                        count2++;
                        Console.Write("[{0},{1}] ", index1, index2);
                    }
                }
            }
            double perc = (count2 / count1) *100;
            Console.WriteLine("\nThe Max Number({0}) was created {1} times out of {2} variables. {3}% of the array!", maxNum, count2, count1, perc);
            
            
            Console.ReadLine();
        }
        
    }
}
