
int number = Prompt("Введите число: ");
FindThirdNumber(number);
int Prompt(string message)
{
	Console.Clear();
	Console.WriteLine(message);
	int num = int.Parse(Console.ReadLine());
	return num;
}

void FindThirdNumber(int num)
{
	if (num < 100)
	{
		Console.WriteLine("Третьей цифры нет");
	}
	else
	{
		while (number >= 1000)
		{
			num = num / 10;
		}
		int thirdNumber = num % 10;
		Console.WriteLine($"Третья цифра числа -> {thirdNumber}");
	}
}