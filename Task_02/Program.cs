// Напишите программу которая на вход принимает целое число N 
// А на выходе показывает все целые числа в промежутке от -N до N.
// Примеры 
// 4 => -4 -3 -2 -1 0 1 2 3 4 

System.Console.WriteLine("Input: ");
int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Number => {number}");


// int index = number * (-1);

// while (index <= number)
// {
// System.Console.Write (index + " ");
// index ++;
// }

int numberAbs = Math.Abs(number); //Модуль MAth возвращает модуль числа если отрицательное то будет положительное
for (int i = -numberAbs; i <= numberAbs; i++)
{
    System.Console.Write(i + " ");
    
}



