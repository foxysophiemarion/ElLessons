
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
	Console.WriteLine("{0} кратно {1}", num2, num1);
}
else
{
	int remainder = num1 % num2;
	Console.WriteLine("{0} не кратно {1}, остаток от деления: {2}", num2, num1, remainder);
}