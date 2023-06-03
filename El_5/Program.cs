
int FindFirstDigit(int num)
{
	int firstNumber = num / 10; // Деление нацело 78=7
	return firstNumber; //Возвпащение переменной
}
int FindSecondDigit(int num)
{
	int secondNumber = num % 10; // Вычисление последней цыфры 
	return secondNumber; //Возвпащение переменной
}



void FindLargestDigit(int num, int firstNumber, int secondNumber)
{
	Console.WriteLine("Рандомное число: " + num); // Показывает сгенерированное число
	Console.WriteLine(firstNumber);
	Console.WriteLine(secondNumber);

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



int number = new Random().Next(10, 100); // Генерация случайного числа 10-99  !!!ГЛОБАЛЬНАЯ ПЕРЕМЕННАЯ!!!


FindLargestDigit(number, FindFirstDigit(number), FindSecondDigit(number)); //Сокращенный способ (К ПЕРЕМЕННЫМ НЕЛЬЗЯ БУДЕТ ОБРАТИТЬСЯ)


int number1 = new Random().Next(100);
int firstDigit1 = FindFirstDigit(number1);
int secondDigit1 = FindSecondDigit(number1);
FindLargestDigit(number1, firstDigit1, secondDigit1); //Развернутый способ (МОЖНО ОБРАТИТЬСЯ К ПЕРЕМЕННЫМ)

int number2 = new Random().Next(-100, 10);
int firstDigit2 = FindFirstDigit(number2);
int secondDigit2 = FindSecondDigit(number2);
FindLargestDigit(number2, firstDigit2, secondDigit2); //Развернутый способ (МОЖНО ОБРАТИТЬСЯ К ПЕРЕМЕННЫМ)


//FindLargestDigit(number1);
//FindLargestDigit(number2);