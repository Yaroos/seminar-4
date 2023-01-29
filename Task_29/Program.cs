/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

// Создание рандомного массива
int [] CreateArray()
{
    int [] Array = new int [8];
    Random number = new Random();
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(-100,100);
    }
    return Array;
} 

// Вызов Массива
int [] a = CreateArray();

// Заполнение массива
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}

// Вызов заполненного массива в консоль
PrintArray(a);

