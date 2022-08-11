//Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b) Console.WriteLine("Треугольник существует!");
else Console.WriteLine("Треугольник не существует!");
