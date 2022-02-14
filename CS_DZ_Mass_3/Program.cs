using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Mass_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string localMaximum = "";
            int[] array = new int[30];
            int maxLength = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 31);
                Console.Write(array[i] + " ");
            }

            if (array[0] > array[1])
            {
                localMaximum += array[0] + " ";
            }

            for (int j = 1; j < array.Length - 1; j++)
            {
                if (array[j] > array[j - 1] && array[j] > array[j + 1])
                {
                    localMaximum += array[j] + " ";
                }
            }
            if (array[array.Length-1] > array[array.Length-2])
            {
                localMaximum += array[array.Length-1];
            }
           
           

            Console.WriteLine("\nЛокальные максимумы: " + localMaximum);
        }
    }
}
