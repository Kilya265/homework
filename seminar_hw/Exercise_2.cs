Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите другое число: ");
int other_number = Convert.ToInt32(Console.ReadLine());

if ((number > other_number) && (number != other_number)) {
    Console.WriteLine(number);
}
else if ((other_number > number) && (number != other_number)) {
    Console.WriteLine(other_number);
} else Console.WriteLine("Числа одинаковы!");