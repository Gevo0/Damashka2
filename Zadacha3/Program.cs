// Задача 15: Напишите программу, которая принимает
//  на вход цифру, обозначающую день недели, и
//   проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7  || num < 0 )
{
    System.Console.WriteLine("не верное число");
}
 
else if(num <= 5)
    {
        System.Console.WriteLine("нет");
    }
else
    {
        System.Console.WriteLine("да");
    }


