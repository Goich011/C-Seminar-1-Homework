// напишите программу которая на вход принимает число n, а на выходе показывает все четные числа от 1 до n.
int n = Convert.ToInt32(new Random().Next(0,20));
Console.WriteLine(n);
int count = 0;
while (count < n)
{
    Console.WriteLine(count);
    count = count + 2;
}