Console.WriteLine("Введите два числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

double squareRoot = Math.Sqrt(num2); // вычисляем корень квадратный из второго числа

if ((squareRoot * squareRoot == num2) && (squareRoot == num1)) //сравниваем квадратный корень второго числа и первое число
{
	Console.WriteLine(num1 + " является квадратом числа " + num2);
}
else
{
	Console.WriteLine(num1 + " не является квадратом числа " + num2);
}