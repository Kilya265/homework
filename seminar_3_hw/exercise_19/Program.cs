// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

void CheckingNumber(string stringNumber){
  if (stringNumber[0]==stringNumber[4] || stringNumber[1]==stringNumber[3]){
    Console.WriteLine($"Число: {stringNumber} - палиндром.");
  }
  else Console.WriteLine($"Число: {stringNumber} - НЕ палиндром.");
}

if (stringNumber.Length == 5){
  CheckingNumber(stringNumber);
}
else Console.WriteLine("Введено не пятизначное число!");