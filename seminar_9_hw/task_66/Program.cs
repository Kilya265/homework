/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = M; i <= N; i++) sum += i;
Console.WriteLine("Сумма натуральных элементов = " + sum);
