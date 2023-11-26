// Напишите программу, которая прнимает на вход трехзнакчное целое число 
// и на выходе показывает сумму первой и последней цифры этого числа.
// 456 =>10

System.Console.WriteLine("Input: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDig = number / 100;
int secondDig = number % 10;

System.Console.WriteLine($"First dig = {firstDig}. Second dig = {secondDig}. Result = {firstDig+secondDig}");
