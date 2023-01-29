//Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
RandonNumbers(num);
Console.WriteLine("В этом массиве: ");
PrintArray(num);

void RandonNumbers(int[] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < num.Length; x++)
{
if (num[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {num.Length} чисел, {count} четных");


void PrintArray(int[] arr)
{
    foreach ( int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}