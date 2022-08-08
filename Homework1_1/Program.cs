// Задача 2: Напишите программу, которая на вход принимает 2 числа и выдает какое число большее а какое меньшее.
int a = Convert.ToInt32(new Random().Next(-100, 100));
Console.WriteLine(a);
int b = Convert.ToInt32(new Random().Next(-100, 100));
Console.WriteLine(b);
int min = a;
int max = b;
int count = 0;

while (a > b)
{
    count = b;
    b = a;
    a = count;
}


Console.Write("min = ");
Console.WriteLine(a);

Console.Write("max = ");
Console.WriteLine(b);