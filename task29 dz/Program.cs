// Задача 29: Напишите программу, которая задаёт массив 
//            из 8 элементов и выводит их на экран.
//  Вводим массив через консоль

Console.Write("Введите 8 чисел для создания массива : ");
string str = Console.ReadLine();
char[] arr = new char[str.Length]; // Создаем массив == длины строки
if (str.Length != 8) //проверка количества цифр в строке
{
Console.WriteLine($"Нужно вводить 8 чисeл");
}
else   
       { // Копируем каждый символ в массив
        for (int i = 0; i < str.Length; i++)
         { 
            arr[i] = str[i]; 
        } 
        Console.WriteLine(string.Join(", ", arr)); //вывод массива
    }
        