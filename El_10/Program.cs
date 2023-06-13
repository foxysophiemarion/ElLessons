int quarter = Prompt("Введите номер четверти: ");
FindQuarter(quarter);

int Prompt(string message)
{
	Console.Write(message);
	int num = Convert.ToInt32(Console.ReadLine());
	return num;
}

void FindQuarter(int num)
{
	if (num == 1)
	{
		Console.WriteLine("x>0, y>0");
	}

	if (num == 2)
	{
		Console.WriteLine("x<0, y>0");
	}

	if (num == 3)
	{
		Console.WriteLine("x<0, y<0");
	}

	if (num == 4)
	{
		Console.WriteLine("x>0, y<0");
	}

	else
	{
		Console.WriteLine("Недопустимый номер четверти.");
	}
}