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

int number = GetNumber("Digit in: ");
while (number > 0)
{
    int B = 0;
    int A = number % 10;
    B = B + A;
    Console.WriteLine(B);
}





// 2. Method. Number in to Array

// 3. Method. Sum digit in number


