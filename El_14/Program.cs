//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456-> 3
//78-> 2
//89126-> 5


Console.Clear();

int number = Prompt("Введите число: ");

int Prompt(string msg)
{
	Console.WriteLine(msg);
	int number = int.Parse(Console.ReadLine()!);
	return number;
}

int count = 0;
while (number != 0)
{
	count++;
	number /= 10;

}

Console.WriteLine($"Количество цифр в числе: {count}");