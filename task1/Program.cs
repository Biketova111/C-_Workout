/* Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада.
На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %, 
если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %. 
Отработав, программа должна вывести общую сумму с начисленными процентами. */

Console.Write("Введите сумму вклада: ");
string sumStr = Console.ReadLine();
double sum = Convert.ToDouble(sumStr);


if (sum >= 100 && sum <= 200)
{
    sum+=sum*0.07;
}
if (sum<100)
{
   sum+=sum*0.05; 
}
if (sum>200)
{
   sum+=sum*0.1; 
}
Console.WriteLine($"Cумма вклада с начислением проценто составит:  {sum}");
