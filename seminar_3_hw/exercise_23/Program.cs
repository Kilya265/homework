// See https://aka.ms/new-console-template for more information

Console.Write("Введите число: ");

int sqr = Convert.ToInt32(Console.ReadLine());

void Sqr(int[] sqr){
  int counter = 0;
  int length = sqr.Length;
  while (counter <  length){
    sqr[counter] = Convert.ToInt32(Math.Pow(counter, 2));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 1;
  while(index < count){
    Console.Write(coll[index]+ "\n");
    index++;
  }
} 

int[] arry = new int[sqr+1];
Sqr(arry);
PrintArry(arry);