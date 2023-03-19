// ДЗ 19 задача
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 10000 || n > 99999)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// ДЗ доп задача
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 11); // [1, 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int max = 0;
// for (int i = 1; i < array.Length - 1; i++)
// {
//     if (max < array[i - 1] + array[i] + array[i + 1])
//         max = array[i - 1] + array[i] + array[i + 1];
// }
// if (max < array[0] + array[array.Length - 1] + array[array.Length - 2])
//     max = array[0] + array[array.Length - 1] + array[array.Length - 2];
// if (max < array[0] + array[1] + array[array.Length - 1])
//     max = array[0] + array[1] + array[array.Length - 1];
// Console.WriteLine(max);

// void f(ref int x)
// {
//     x = x + 10;
// }
// Console.Clear();
// int n = 5;
// f(ref n);
// Console.WriteLine(n);

// Console.Clear();
// int[] array = {1, 2, 3, 4, 5};
// f(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// int maxNumbers(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }

// Console.Clear();
// int n = 5, m = 7;
// Console.WriteLine(maxNumbers(n, m));



// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// int SumPositiveInArray(int[] array)
// {
//     int summa = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             summa += array[i];
//     }
//     return summa;
// }

// int SumNegativeInArray(int[] array)
// {
//     int summa = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             summa += array[i];
//     }
//     return summa;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма положительных чисел равна {SumPositiveInArray(array)}");
// Console.WriteLine($"Сумма отрицательный чисел равна {SumNegativeInArray(array)}");


// Задача 32
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// int[] ReplaceNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
//     return array;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Конечный массив: [{string.Join(", ", ReplaceNumbers(array))}]");


//Задача 33
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }

// string CheckNumber(int[] array, int n)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == n)
//             return "yes";
//     }
//     return "no";
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое Вы хотите найти: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine(CheckNumber(array, number));

//Задача 35
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101); // [-100; 100]
// }

// int CountNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// // Console.Write("Введите кол-во элементов в массиве: ");
// // int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(CountNumbers(array));

// Задача 37

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1, 10]
// }

// void ProizvedenieNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//         Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов в массиве: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ProizvedenieNumbers(array);

