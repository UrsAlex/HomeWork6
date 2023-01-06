// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисео больше 0 ввел пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3


// int PrintArray(string text)
// {
//     Console.WriteLine(text);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }

// PrintArray("введите числа");


Console.Write("ВВедите числа (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Количество чисел больше 0 равно {count}");