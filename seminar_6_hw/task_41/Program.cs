//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int array(int[] n) {
    int count = 0;
    foreach (var element in n) {
        if (element > 0) count++;
    }
    return count;
}
Console.WriteLine(array(n));
