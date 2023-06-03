
void FindLargestFigit(int num)
{
	int firstNumber = num / 10; // Деление нацело 78=7
	int secondNumber = num % 10; // Вычисление последней цыфры 78=8
	Console.WriteLine("Рандомное число: " + num); // Показывает сгенерированное число
	Console.WriteLine(firstNumber); // Показывает первую цифру сгенерированого числа
	Console.WriteLine(secondNumber); // Показывает вторую цифру сгенерированого числа
	if (firstNumber > secondNumber)
	{
		Console.WriteLine("Первая цифра больше второй");
	} // Условие срабатывает, если первая цифра больше второй
	else if (secondNumber > firstNumber)
	{
		Console.WriteLine("Вторая цифра больше первой");
	} // Условие срабатывает, если вторая цифра больше первой
	else
	{
		Console.WriteLine("Цифры равны");
	} // Условие срабатывает, если цифры равны
}

int number = new Random().Next(10, 100);
int number1 = new Random().Next(100);
int number2 = new Random().Next(-100, 10); // Генерация случайного числа 10-99  !!!ГЛОБАЛЬНАЯ ПЕРЕМЕННАЯ!!!
FindLargestFigit(number);
FindLargestFigit(number1);
FindLargestFigit(number2);