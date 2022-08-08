// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное их этих чисел.
int a = Convert.ToInt32(new Random().Next(-100, 100));
Console.WriteLine(a);
int b = Convert.ToInt32(new Random().Next(-100, 100));
Console.WriteLine(b);
int c = Convert.ToInt32(new Random().Next(-100, 100));
Console.WriteLine(c);

if(a > b && a > c)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
if(b > a && b > c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
if(c > a && c > b)
{
    Console.Write("max = ");
    Console.WriteLine(c);
}