//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int[4];
int sum = 0;

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(-10, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++) {
    if (j % 2  == 1) sum += array[j];
}

Console.WriteLine("Сумма чисел, стоящих на нечетных позициях = " + sum);
