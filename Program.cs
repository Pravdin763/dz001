Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 < num2)
{
Console.WriteLine($"{num1} меньше, чем {num2}");
}
else
{
Console.WriteLine($"{num1} больше, чем {num2}");
}


Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

if (num%2==0)
{
Console.WriteLine("ДА");    
}
else
{
Console.WriteLine("НЕТ");     
}


Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i<=num; i++)
    if (i%2==0)
    {
    Console.WriteLine(i);
    }