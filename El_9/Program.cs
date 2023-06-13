
int x1 = Prompt("Введите координату X: ");
int y1 = Prompt("Введите координату Y: ");
FindCoordinate(x1, y1);


int Prompt(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine());
	return num;
}

void FindCoordinate(int x, int y)
{
	if (x > 0 && y > 0)
	{
		Console.WriteLine("Точка находится в первой четверти");
	}

	if (x < 0 && y > 0)
	{
		Console.WriteLine("Точка находится во второй четверти");
	}

	if (x < 0 && y < 0)
	{
		Console.WriteLine("Точка находится в третьей четверти");
	}

	if (x > 0 && y < 0)
	{
		Console.WriteLine("Точка находится в четвертой четверти");
	}
}