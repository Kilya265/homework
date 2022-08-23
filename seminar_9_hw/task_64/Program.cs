/*
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N
*/

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {M}, N = {N}");
for (int i = M; i <= N; i++) Console.Write(i + " ");
Console.WriteLine();
