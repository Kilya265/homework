//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = (int)Math.Log10(x) + 1;
Console.WriteLine("Кол-во цифр в числе: " + count);
