// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int enter = Convert.ToInt32(Console.ReadLine());
int number = enter; //переменная для красивого вывода в конце
int sum = 0;

while (enter > 0)
{
    sum += enter % 10;
    enter /= 10;
}

Console.WriteLine($"Сумма цифр в числе {number} равняется {sum}");