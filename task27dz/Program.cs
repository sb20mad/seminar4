// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число A ");
int n = Convert.ToInt32(Console.ReadLine());

int counter = Convert.ToString(n).Length;
int sum = 0;
int result = 0;

for (int i = 0; i < counter; i++)
{
    sum = n - n % 10;
    result = result + (n - sum);
    n = n / 10;      
}

Console.WriteLine($"число {result} ");

