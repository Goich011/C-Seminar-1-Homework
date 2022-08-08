// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число чётным(делитлся ли оно на 2 без остатка).

int a = Convert.ToInt32(new Random().Next(-100,100));
Console.WriteLine(a);

if (a % 2 == 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Нечетное");