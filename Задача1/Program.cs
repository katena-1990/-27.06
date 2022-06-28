//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int first = number / 100;
int second = (number / 10) % 10;
int third = number % 10;

Console.WriteLine($"Вторая цифра {second}");