//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("массив: ");
PrintArray(num);
int sum = 0;

for (int z = 0; z < num.Length; z+=2)
{
    sum = sum + num[z];

    Console.WriteLine($"всего {num.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
}

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = new Random().Next(1,10);
        }
}

void PrintArray(int[] arr)
{
    foreach ( int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}