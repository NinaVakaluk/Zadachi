Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
if (number1%2==0)
{
    Console.WriteLine($"Число {number1} является четным");
}
else
{
    Console.WriteLine($"Число {number1} является не четным");
}