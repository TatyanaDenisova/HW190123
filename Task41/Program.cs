/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int getUserData(string message)
{
    Console.WriteLine(message);
    int length = int.Parse(Console.ReadLine()!);
    return length;
}
int[] fullArray(int length, int interval)
{
    int[]array = new int [length];
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-interval, interval+1);
    }
return array;
} 
int countPositiveNumbers(int[]array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
         Console.ResetColor();  
    }
    Console.WriteLine("]");
}


int length= getUserData("Введите число М");
int[]array = fullArray(length, 10);
PrintArray(array);
int count = countPositiveNumbers(array);
Console.Write($"Количество чисел больше 0 равно {count}");
