/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

// 1. Method. Get a number

int GetNumber(string message)
{
    int resultNumber = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
        Console.WriteLine("Введено не корректное число. Попробуйте еще раз.");
        }
    }
    return resultNumber;
}

int number = GetNumber("Введите число: ");
int B = 0;
while (number > 0)
{
    int A = number % 10;
    number = number / 10;
    B =  B + A;
    
}
Console.WriteLine($"Сумма цифр числа = {B}");