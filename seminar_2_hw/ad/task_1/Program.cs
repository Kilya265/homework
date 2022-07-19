// See https://aka.ms/new-console-template for more information
Random rndm = new Random();

int value = rndm.Next(100, 1000);
Console.WriteLine($"Трёзначное число: {value}");

string result = Convert.ToString(value);

Console.Write("Результат: ");
Console.Write(result[0]);
Console.Write(result[2]);
