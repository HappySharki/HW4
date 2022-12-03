//Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов 
//и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]



using static System.Console;
Clear();

WriteLine("Введите 8 чисел: ");
int number1 = Convert.ToInt32(ReadLine());
int number2 = Convert.ToInt32(ReadLine());
int number3 = Convert.ToInt32(ReadLine());
int number4 = Convert.ToInt32(ReadLine());
int number5 = Convert.ToInt32(ReadLine());
int number6 = Convert.ToInt32(ReadLine());
int number7 = Convert.ToInt32(ReadLine());
int number8 = Convert.ToInt32(ReadLine());

int[] array1 = new int[] {number1, number2, number3, number4, number5};
int[] array2 = new int[] {number6, number7, number8};
var str = string.Join(" ", array1);
WriteLine($"[{str}]");
var str2 = string.Join(" ", array2);
WriteLine($"[{str2}]");