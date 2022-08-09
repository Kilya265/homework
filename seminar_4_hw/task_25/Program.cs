//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int IntPow(int a, int b) {
  int result = 1;
  for(int i=1; i <= b; i++) {
    result *= a;
  }
    return result;
}
Console.WriteLine("Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());
int intPow = IntPow(a, b);
Console.WriteLine("Ответ: " + intPow);
