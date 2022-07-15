Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int third_number = Convert.ToInt32(Console.ReadLine());

int max = first_number;

if (second_number > max) max = second_number;
if (third_number > max) max = third_number;

Console.WriteLine(max);