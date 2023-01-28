/* Если целое число m делится нацело на целое число n, то вывести на экран частное от деления, 
в противном случае вывести сообщение «m на n нацело не делится».*/

Console.Write("Введите первое число, m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число, n = ");
int n = Convert.ToInt32(Console.ReadLine());

if (m%n == 0)
{
    Console.WriteLine($"m/n = {m/n}");
}
else
{
    Console.WriteLine("m на n нацело не делится");
    
}