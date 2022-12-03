//Задача 25: 
//Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A 
//в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16


using static System.Console;
Clear();

WriteLine("Введите число: ");
double num1 = Convert.ToDouble(ReadLine());
WriteLine("Введите в какую степень возвести это число: ");
double num2 = Convert.ToDouble(ReadLine());

WriteLine(Math.Pow(num1, num2));