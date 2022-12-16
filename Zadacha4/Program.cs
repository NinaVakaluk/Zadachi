Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int N = 1;

while(N <= num)
{
   if(N % 2 == 0)
    {
    Console.WriteLine($"Числа {N}");
    N++;
    }
    else
    {
        N++;
    } 
}

   
    

 

