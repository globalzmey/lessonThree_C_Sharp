/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void toFill(int[] cubes){
  int counter = 1;
  int length = cubes.Length;
  while (counter < length){
    cubes[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintCubes(int[] quantity){
  int count = quantity.Length;
  int index = 1;
  while(index < count){
    Console.Write(quantity[index]+ " ");
    index++;
  }
} 

int[] arry = new int[num + 1];
toFill(arry);
Console.Write(num + " -> ");
PrintCubes(arry);
Console.WriteLine();
