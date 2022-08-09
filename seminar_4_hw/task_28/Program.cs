//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= x; i++) {
    result *= i;
}

Console.WriteLine("Произведение элементов от 1 до " + x + ": " + result);
