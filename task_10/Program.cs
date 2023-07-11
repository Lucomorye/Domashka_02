// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите трёх значное число");
int number = int.Parse(Console.ReadLine());
if((number > 99 && number < -99) || (number < 1000 && number > -1000))
{
  number = number / 10 % 10;
  Console.WriteLine(number);
}
else
{
  Console.WriteLine("Вы ввели не трёхзначное число");
}
