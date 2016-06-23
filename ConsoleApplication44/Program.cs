using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        //рекурсивный метод вычисление факториала
        static int f(int i)
        {
            int res;
            if (i == 1)
                return 1;
            res = f(i - 1) * i;

            return res;
        }

        //циклический метод вычисление факториала
        static int fa(int z)
        {
            int res = 1;
            for (int i = 2; i <= z; i++)
            {
                res = res * i;
            }
            return res;
        }

        //Сортировка по минимальному значению
        static int[] MySort(int[] mas)

        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                int t = mas[min];
                mas[min] = mas[i];
                mas[i] = t;
            }
            return mas;
        }

        static void Main(string[] args)
        {
            //1 задание
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! равно {1}", a, f(a));
            Console.WriteLine("{0}! равно {1}", a, fa(a));
            Console.ReadLine();

            //2 задание
            int[] mas = { 4, 3, 67, 7, 1, 2 };
            MySort(mas);
            Console.WriteLine(string.Join("\r\n", mas));

            //3 задание
            int n = 1;
            string s = Console.ReadLine();
            int key = 2;

            string s1 = "";

            string alfavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            int m = alfavit.Length; 

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (s[i] == alfavit[j]) 
                    {
                        int t = j * n + key;

                        while (t >= m)
                            t -= m;

                        s1 = s1 + alfavit[t];
                    }
                }

            }

            Console.WriteLine("Зашифрованное слово:" + s1);
            Console.ReadLine();

        }
    }
}
