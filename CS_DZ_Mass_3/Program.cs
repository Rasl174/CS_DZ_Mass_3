﻿using System;
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

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(0, 21);
                Console.Write(array[i] + " ");

                if ((i == array.GetLength(0) - 1) && (array[0] > array[1]))
                {
                    localMaximum += array[0] + " ";
                }

                if (i == array.GetLength(0) - 1)
                {
                    for (int j = 1; j < array.GetLength(0) - 1; j++)
                    {

                        if (array[j] > array[j + 1] && array[j] > array[j - 1])
                        {
                            localMaximum += array[j] + " ";
                        }

                    }

                }

                if ((i == array.GetLength(0) - 1) && (array[array.GetLength(0) - 1] > array[array.GetLength(0) - 2]))
                {
                    localMaximum += "" + array[array.GetLength(0) - 1];
                }

            }
            Console.WriteLine("\nЛокальные максимумы: " + localMaximum);
        }
    }
}
