// Задание 1. 
// Напишите программу, которая на вход принимает два целых числа и проверяет,
// является ли первое число квадратом второго.


// string text = "Text";
// double nubmer = 3.45;


System.Console.Write("input number1: ");
string num1String = Console.ReadLine();
int number1 = Convert.ToInt32(num1String);

System.Console.Write("input number2: ");
int nubmer2 = Convert.ToInt32(Console.ReadLine());



if (number1 == Math.Pow(nubmer2,2))
{
    Console.WriteLine("yes");

}
else {
    Console.WriteLine("no");
}

