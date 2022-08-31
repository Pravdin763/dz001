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
