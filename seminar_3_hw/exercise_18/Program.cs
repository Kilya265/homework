// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер Четверти: ");

int n = Int32.Parse(Console.ReadLine());

if (n == 1) {
    Console.WriteLine("x[0;∞) и y[0;∞)");
} else if (n == 2) {
    Console.WriteLine("x(-∞;0] и y[0;∞)");
} else if (n == 3) {
    Console.WriteLine("x(-∞;0] и y(-∞;0]");
} else if (n == 4) {
    Console.WriteLine("x[0;∞) и y(-∞;0]");
} else {
    Console.WriteLine("Неправильный ввод!");
}
