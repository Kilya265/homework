// See https://aka.ms/new-console-template for more information
 Console.Write("Введите число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

if (stringNumber.Length > 2) Console.WriteLine("Вторая цифра этого числа: "+stringNumber[1]);
else Console.WriteLine("Введено не трёхзначное число!");