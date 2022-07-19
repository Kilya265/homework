// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
int res;

if (day > 7) res = day % 7;
else res = day;

Console.WriteLine(res);

Console.WriteLine("Этот день выходной?");
if (res == 0 || res > 5) Console.WriteLine("да");
else Console.WriteLine("нет");