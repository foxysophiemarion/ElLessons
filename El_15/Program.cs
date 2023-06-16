//Задача 28: Напишите программу, которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.

Console.Clear();


int Prompt(string msg)
{
	Console.WriteLine(msg);
	int number = int.Parse(Console.ReadLine());
	return number;
}


int Multipli(int number)
{
	int mult = 1;
	for (int i = 1; i <= number; i++)
	{
		mult = mult * i;
		Console.Write(mult + " ");
	}
	return mult;
}

int num = Prompt("Введите число: ");

Console.WriteLine($"Произведение чисел: {Multipli(num)}");