//Задание 1. Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) 
//дробных чисел с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а
//двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива
//А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент,
//общую сумму всех элементов, общее произведение всех элементов, сумму четных элементов массива А,
//сумму нечетных столбцов массива В.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Practice1
{
    class Program
    {    
        static void Main(string[] args) 
        {
            int[] A = new int[5];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(string.Format("Введите {0}й элемент массива:", i + 1));
                A[i] = Convert.ToInt32(Console.ReadLine());                                                            
            }                  
            
            Random rnd = new Random();
            float[,] B = new float[3, 5];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                    B[i, j] = rnd.Next(1, 10);
            }

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
