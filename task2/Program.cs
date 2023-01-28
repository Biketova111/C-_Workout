/* Пользователь вводит три числа. Увеличьте первое число в два раза, второе числа уменьшите на 3,
третье число возведите в квадрат и затем найдите сумму новых трех чисел. */

Console.Write("Введите первое число: a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: c = ");
int c = Convert.ToInt32(Console.ReadLine());

a = a*2;
b = b-3;
c = c*c;

Console.WriteLine($"a = {a}, b = {b}, c = {c}");
Console.WriteLine($"Сумма новых а, b и c равна: {a+b+c}");

