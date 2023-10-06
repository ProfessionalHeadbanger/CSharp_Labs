using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        bool is_right = false;
        while (!is_right)
        {
            Console.Write("Введите количество массивов N: ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                is_right = true;
            }
            else
            {
                Console.WriteLine("Неправильный ввод, N должно быть натуральным числом");
            }
        }
        List<int>[] arrays = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элементы массива {i + 1} через пробел: ");
            string input = Console.ReadLine();
            string[] elements = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> currentArray = new List<int>();
            foreach (string element in elements)
            {
                if (int.TryParse(element, out int value))
                {
                    currentArray.Add(value);
                }
                else
                {
                    Console.WriteLine($"Некорректный элемент '{element}' в массиве {i + 1}. Элемент будет проигнорирован.");
                }
            }

            arrays[i] = currentArray;
        }

        List<int> intersection = FindIntersection(arrays);

        Console.WriteLine("Пересечение введенных массивов: " + string.Join(", ", intersection));
    }

    static List<int> FindIntersection(List<int>[] arrays)
    {
        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        foreach (var array in arrays)
        {
            foreach (var element in array)
            {
                if (elementCount.ContainsKey(element))
                {
                    elementCount[element]++;
                }
                else
                {
                    elementCount[element] = 1;
                }
            }
        }

        List<int> intersection = new List<int>();

        foreach (var dict_pair in elementCount)
        {
            if (dict_pair.Value == arrays.Length)
            {
                intersection.Add(dict_pair.Key);
            }
        }

        return intersection;
    }
}