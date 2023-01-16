using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которой создается одномерный числовой массив и заполняется числами,
            //которые при делении на 5 дают в остатке 2(числа 2, 7, 12, 17 и так далее).
            //Размер массива вводится пользователем. Предусмотреть обработку ошибки, связанной с вводом некорректного значения.

            /*int num, number = 0;
            try
            {
                Console.Write("Введите число: ");
                num = int.Parse(Console.ReadLine());
                int[] array = new int[num];
                Console.WriteLine("Массив: ");

                for (int i = 0; i < array.Length; i++)
                {
                    while (number % 5 != 2)
                    {
                        number++;
                    }
                    array[i] = number;
                    Console.Write(array[i] + " ");
                    number++;
                }
            }
            catch
            {
                Console.WriteLine("Введите число.");
            }
            Console.ReadKey();*/

            //Напишите программу, в которой создается массив из 11 целочисленных элементов. Массив заполняется степенями двойки — числами 20 = 1, 2
            //1 = 2, 2 2 = 4, 2 3 = 8 и так далее до 2 10 = 1024.
            //При заполнении массива учесть, что начальный элемент равен 1, а каждый следующий больше предыдущего в 2 раза.
            //Отобразить массив в консольном окне в прямом и обратном порядке. Размер массива задается переменной.

            /*int max = 2048, c = 12;
            int[] array = new int[c];
            Console.WriteLine("Массив в прямом порядке: ");
            for (int k = 11; k >= 0; k--)
            {
                max = max / 2;
                array[k] = max;
                Console.Write(array[k] + " ");
            }
            Console.WriteLine("\nМассив в обратном порядке: ");
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }
            Console.ReadKey();*/

            //Напишите программу, в которой создается одномерный символьный массив из 10 элементов.
            //Массив заполняется буквами «через одну», начиная с буквы ’а’: то есть массив заполняется буквами ‘а’, ‘с’, ‘е’, ‘g’ и так далее.
            //Отобразите массив в консольном окне в прямом и обратном порядке. Размер массива задается переменной.

            /*char ch = 'a';
            int num = 10;
            char[] array = new char[num];
            Console.WriteLine("Массив в прямом порядке: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ch;
                ch = (char)(int)(ch + 2);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nМассив в обратном порядке: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.Readkey();*/

            //Напишите программу, в которой создается символьный массив из 10 элементов.
            //Массив заполнить большими(прописными) буквами английского алфавита.
            //Буквы берутся подряд, но только согласные(то есть гласные буквы ‘А’, ‘Е’ и ‘I’ при присваивании значений элементам массива нужно пропустить).
            //Отобразите содержимое созданного массива в консольном окне.

            /*char ch = 'A';
            char[] array = new char[10];
            for (int i = 0; i < array.Length; i++)
            {
                switch (ch)
                {
                    case 'A':
                        ch++;
                        break;
                    case 'E':
                        ch++;
                        break;
                    case 'Y':
                        ch++;
                        break;
                    case 'U':
                        ch++;
                        break;
                    case 'O':
                        ch++;
                        break;
                    case 'I':
                        ch++;
                        break;
                }
                array[i] = ch;
                ch++;
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();*/

            //Напишите программу, в которой создается массив и заполняется случайными числами.
            //Массив отображается в консольном окне. В этом массиве необходимо определить элемент с минимальным значением.
            //В частности, программа должна вывести значение элемента с минимальным значением и индекс этого элемента.
            //Если элементов с минимальным значением несколько, должны быть выведены индексы всех этих элементов.

            /*int num;
            Random rnd = new Random();
            Console.Write("Введите количество элементов массива: ");
            num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            int min = array[0], index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }

            Console.WriteLine($"\nМинимальное число - {min}.");
            Console.WriteLine($"Индекс минимального числа - {index}.");
            Console.ReadLine();*/

            //Напишите программу, в которой создается целочисленный массив, заполняется случайными
            //числами и после этого значения элементов в массиве сортируются в порядке убывания значений.

            /*int num;
            Random rnd = new Random();
            Console.Write("Введите количество элементов массива: ");
            num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("\nМассив после сортировки: ");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();*/

            //Напишите программу, в которой создается символьный массив, а затем порядок элементов в массиве меняется на обратный.

            /*int num;
            Random rnd = new Random();
            Console.Write("Введите количество элементов массива: ");
            num = int.Parse(Console.ReadLine());
            char[] array = new char[num];
            Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < num; i++)
            {
                array[i] = (char)rnd.Next(0x0410, 0x44F);
                Console.Write(array[i] + " ");
            }

            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("\nМассив после сортировки: ");

            foreach (char i in array)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();*/

            //Напишите программу, в которой создается и инициализируется двумерный числовой массив.
            //Затем из этого массива удаляется строка и столбец (создается новый массив, в котором по сравнению с исходным удалена одна строка и один столбец).
            //Индекс удаляемой строки и индекс удаляемого столбца определяется с помощью генератора случайных чисел.

            /*int num, line, column;
            Console.Write("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            int[,] arrayTwo = new int[n, m];
            Random rnd = new Random();
            Console.WriteLine(" Исходный массив: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    num = rnd.Next(0, 100);
                    array[i, j] = num;
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            line = rnd.Next(0, n);
            column = rnd.Next(0, m);
            Console.WriteLine($"\nИндекс столбца = {column} \nИндекс строки = {line}\n\nПолученный массив: ");

            for (int i = 0; i < arrayTwo.GetLength(0); i++)
            {
                if (i != line)
                {
                    for (int j = 0; j < arrayTwo.GetLength(1); j++)
                    {
                        if (j != column)
                        {
                            arrayTwo[i, j] = array[i, j];
                            Console.Write(arrayTwo[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();*/
        }
    }
}
