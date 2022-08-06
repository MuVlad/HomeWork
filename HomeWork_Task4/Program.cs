// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int third_number = Convert.ToInt32(Console.ReadLine());

if(first_number > second_number & first_number > third_number)
{
    Console.WriteLine("max = " + first_number);
}
else if(second_number > first_number & second_number > third_number)
{
    Console.WriteLine("max = " + second_number);
}
else if(third_number > first_number & third_number > second_number)
{
    Console.WriteLine("max = " + third_number);
}