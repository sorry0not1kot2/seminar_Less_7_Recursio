// Семинар урок 7 аттестация

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m == n)
        {
            Console.Write(n); // Выводим последнее число диапазона
        }
        else if (m < n)
        {
            Console.Write(m + ", "); // Выводим текущее число и запятую
            PrintNumbers(m + 1, n); // Рекурсивный вызов с увеличением m
        }
        else // m > n
        {
            Console.Write(m + ", "); // Выводим текущее число и запятую
            PrintNumbers(m - 1, n); // Рекурсивный вызов с уменьшением m
        }
    }

    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine()); // Считываем значение M
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine()); // Считываем значение N

        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
        PrintNumbers(m, n); // Вызываем функцию для печати чисел
        Console.WriteLine();
    }
}

// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n

// using System;

// class Program
// {
//     static int Akerman(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0 && m > 0)
//         {
//             return Akerman(m - 1, 1);
//         }
//         else
//         {
//             return Akerman(m - 1, Akerman(m, n - 1));
//         }
//     }

//     static void Main()
//     {
//         Console.WriteLine("Введите неотрицательные числа m и n для функции Аккермана:");
//         Console.Write("m = ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.Write("n = ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         if (m < 0 || n < 0)
//         {
//             Console.WriteLine("Числа должны быть неотрицательными.");
//         }
//         else
//         {
//             int result = Akerman(m, n);
//             Console.WriteLine($"Результат функции Аккермана A({m}, {n}) = {result}");
//         }
//     }
// }


// // Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// // Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static Random random = new Random();

    // Метод для рекурсивного заполнения массива случайными числами
    static void FillArrayRecursively(int[] array, int index)
    {
        if (index < array.Length)
        {
            array[index] = random.Next(100); // Заполняем массив случайными числами до 100
            Console.Write(array[index] + " "); // Печатаем элемент сразу после его заполнения
            FillArrayRecursively(array, index + 1);
        }
    }

    // Метод для рекурсивной печати элементов массива в обратном порядке
    static void ReversePrint(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            ReversePrint(arr, index - 1);
        }
    }

    static void Main()
    {
        // Запрос размера массива у пользователя
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] myArray = new int[size];

        Console.Write("Сгенерированный массив: ");
        FillArrayRecursively(myArray, 0);
        Console.WriteLine(); // Переход на новую строку после печати массива

        Console.Write("Перевернутый массив: ");
        ReversePrint(myArray, myArray.Length - 1);
        Console.WriteLine(); // Переход на новую строку после печати массива
    }
}
