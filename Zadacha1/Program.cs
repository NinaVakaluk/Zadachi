Console.WriteLine("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 == number2)
{
    Console.WriteLine($"Первое число {number1} равно второму числу {number2}");
}
else
{
   if (number1 > number2)
{
    Console.WriteLine($"Первое число {number1} является большим,а второе число {number2} меньшим");
}
else
{
    Console.WriteLine($"Второе число {number2} является большим, а первое число {number1} меньшим");
}
 
}

