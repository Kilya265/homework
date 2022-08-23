/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = ack(M, N);

int ack(int M, int N) {
    if (M == 0) return N + 1;
    else if (N == 0) return ack(M - 1, 1);
    else return ack(M - 1, ack(M, N - 1));
}
Console.Write($"Функция Аккермана = {functionAkkerman} ");
Console.WriteLine();
