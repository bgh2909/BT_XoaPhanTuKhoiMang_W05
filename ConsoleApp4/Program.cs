using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = array1.Length;
            int[] array2 = new int[n];

            Console.WriteLine("Array: ");
            foreach (int i in array1)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            Console.Write("Enter the number you want to delete: ");
            int delete_number = int.Parse(Console.ReadLine());
            
            int delete_index = -1;

            for (int i = 0; i < array1.Length;i++)
            {
                if (array1[i] == delete_number)
                {
                    delete_index = i;
                }
            }
            
            if (delete_index >= 0 && delete_index <= array1.Length)
            {
                Console.WriteLine("Number {0} appears in the position {1}.",delete_number,(delete_index+1));
                DeleteNumber(array1, array2, delete_index);
                Console.WriteLine("Array after change: ");
                foreach (int i in array2)
                {
                    Console.Write(i + ", ");
                }
            }
            else
            {
                Console.WriteLine("Number {0} does not exist in array.", delete_number);
            }
            



            Console.ReadKey();
        }


        public static void DeleteNumber(int[] array1, int[] array2,int delete_index)
        { 
            if (delete_index < 0 || delete_index > array1.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            else
            {
                for (int i = 0; i < delete_index;i++) 
                {
                    array2[i] = array1[i];
                }
                for (int j = delete_index; j < array1.Length-1; j++)
                {
                    array2[j] = array1[j+1];
                }
                return;
            }
        }
    }
}
