//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: 0 и 1.


Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int firstNumber = 0;
int secondNumber = 1;
int result = 0;
Console.Write($"{firstNumber}, {secondNumber}");

for (int i = 2; i < n; i++) {
    result = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = result;
    Console.Write($", {result}");
}
Console.WriteLine();
