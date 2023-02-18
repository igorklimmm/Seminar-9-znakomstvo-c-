// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNumbers (int m,int n)
{
    int result = m;
    if (m == n)
    {
        return 0;
    }
    else
    {
     m++;
     result = m + SumNumbers (m,n);
     return result;
    }
}
 

Console.WriteLine("Натуральные числа от: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("До: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма натуральных чисел: " + SumNumbers (m-1,n));