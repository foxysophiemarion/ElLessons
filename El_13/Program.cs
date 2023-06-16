Console.Clear();

string mess = "Введите число: ";
int num = Prompt(mess);
int summ = GetSumNums(num);

Console.WriteLine($"Сумма = {summ}");

int Prompt(string msg)
{
	Console.WriteLine(msg);
	int number = int.Parse(Console.ReadLine());
	return number;
}



//int sum = 0;
//for (int i = 1; i <= num; i++)
//{
//	sum += i;
//}

//Console.WriteLine("Сумма чисел от 1 до {0} равна {1}", num, sum);

int GetSumNums(int number)
{
	int sum = 0;
	for (int i = 1; i <= number; i++)
	{
		sum += i;
		Console.Write(sum + " ");
	}
	return sum;
}

