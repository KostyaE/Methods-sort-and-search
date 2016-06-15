using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
        class Program
        {
            static void Main(string[] args)
            {
                BinarySearch();
            }

            public static void BinarySearch() // Поиск числа бинарным методом 

            {
                int i, mid = 0, left, right;
                int x = 9; // искомое число
                int[] chislo = new int[21];
                for (i = 0; i < 21; i++)
                    chislo[i] = i + 1;

                left = 0; right = chislo.Length - 1;
                while (left <= right)
                {
                    mid = left + (right - left) / 2;
                    if (x < chislo[mid])
                        right = mid - 1;
                    else
                    {

                        if (x > chislo[mid])
                            left = mid + 1;
                        else
                        {
                            break;
                        }

                    }
                }
                Console.Write("Искомое число" + " " + mid);
                Console.WriteLine();

            }
        }
    }
