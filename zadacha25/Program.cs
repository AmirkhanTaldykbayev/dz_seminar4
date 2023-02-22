// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите натуральную степень, в которую нужно возвести число {A}: ");
int B = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= B; i++)
{
    Console.WriteLine($"Возводение числа {A} в степень {i} = {Math.Pow(A, i)}");
}