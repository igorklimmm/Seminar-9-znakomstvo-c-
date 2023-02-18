// Задача 64: Задайте значение N
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
// N = 5-> "5, 4, 3, 2, 1"
// N = 8 -> 8.7.6.5.43.2.1"

void NaturalString (int number)

{
 if (number == 0)
 {
    return;
 }
 NaturalString (number-1);

 if (number % 2 == 0 )
 {
 Console.Write(number + " ");
 }
}

Console.WriteLine("Натуральные числа от 1 до: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalString(number);