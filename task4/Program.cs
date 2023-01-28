/* Дано натуральное число. Определить:
а) является ли оно четным;
б) оканчивается ли оно цифрой 7. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
{
    Console.WriteLine("Введенное число нечетное");
}
if (number%10 == 7)
{
    Console.WriteLine("Данное число оканчивается цифрой 7");
}
else
{
    Console.WriteLine("Данное число не оканчивается цифрой 7");
}