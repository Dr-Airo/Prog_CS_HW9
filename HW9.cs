/*Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());

void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write(number+" ");
    NumberCounter (number - 1);
}

NumberCounter(number);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите целое положительное число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое положительное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
 
// void GapNumberSum (int M, int N, int sum)
// {
//     if (M > N) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (M++);
//     GapNumberSum(M, N, sum);
// }

// GapNumberSum(M, N, 0);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите начальное число M:");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int N = Convert.ToInt32(Console.ReadLine());

// int AckermannFunction (int M, int N)
// {
//     if (M == 0) return N + 1;
//     if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
//     if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
// return AckermannFunction(M, N);
// }

// Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");