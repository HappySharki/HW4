//Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

using static System.Console;
Clear();

int SumOfNumbers(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
return sum;
}

WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine($"Сумма всех цифр в числе = {SumOfNumbers(number)}");