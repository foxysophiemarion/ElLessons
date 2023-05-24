Console.WriteLine("Введите два числа, программа проверит, является ли первое квадратом второго");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int result = num2 * num2;

if (result == num1)
{
	Console.WriteLine(num1 + " является квадратом числа " + num2);
}
else
{
	Console.WriteLine(num1 + " не является квадратом числа " + num2);
}