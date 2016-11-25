using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10;
            int[] array = new int[max];
            enter_data( max, array);
             for (int i=0; i<max; i++)
            {
                for (int j=0; j<max; j++)
                {
                    if(swap(array[i], array[j])!=0)
                    {
                        replace(i, j, array);
                    }
                }
            }
            output(max, array);

            
        }
        static void enter_data (int max, params int[] arr)
        {
            Console.WriteLine("Please, Enter array");
            for (int i=0; i<max; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static int swap(int number_1, int number_2)
            {
            if(number_1 > number_2)
                return 0;
            else return 1;

            
        }
        static void replace (int i, int j, params int[] arr)
        {
            int number = 0;
            number = arr[i];
            arr[i] = arr[j];
            arr[j] = number;
        }
        static void output (int max, params int[] arr)
        {
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < max; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
