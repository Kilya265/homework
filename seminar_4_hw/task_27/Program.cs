//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
foreach (char a in x.ToString())
sum += Convert.ToInt32(a.ToString());
Console.WriteLine("Сумма цифр: " + sum);
