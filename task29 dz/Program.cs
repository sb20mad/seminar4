// Задача 29: Напишите программу, которая задаёт массив 
//            из 8 элементов и выводит их на экран.
//  Вводим массив через консоль


// int[] arr = new int[8];
// string? seriesOfNumbers = Console.ReadLine();
//Random rand = new Random();
// Console.WriteLine("Введите число A ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i=0; i<arr.Length; i++)
// {
//     arr[i] = rand.Next(0, 2);
// }
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write("mas[" + i + "," + j + "]: ");
        mas[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine();