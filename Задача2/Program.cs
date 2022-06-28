//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 99 && number < 1000)
{
    Console.WriteLine($"Последняя цифра {number%10}");
}
else 
{
    Console.WriteLine("Третья цифра отсутствует");
}


