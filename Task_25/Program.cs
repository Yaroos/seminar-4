/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

// 1 Method. Get 2 number: A and B.
int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Введеное число не корректно. Попробуйте еще раз");
        }
    }
    return resultNumber;
}
int A = GetNumber("ВВедите число A: ");
int B = GetNumber("ВВедите число B: ");

// 2 Method. Еxponentiation A in B.

int Exponentation(int A, int B)
{
    int i = 0;
    int C = A;
    for (i = 1; i < B; i++)
    {
        C = C * A;
        Console.WriteLine(C);
    }
    return C;
}
Console.WriteLine($"Число {A} в степени {B} = {Exponentation(A,B)}");