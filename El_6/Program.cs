
int number = new Random().Next(100, 1000);
Console.WriteLine("Сгенерированое число: " + number);

void FindNewDigit(int num)
{
	int firstNumber = number / 100; // Деление нацело 78=7
	int secondNumber = (number / 10) % 10;
	int thirdNumber = number % 10;
	int newNumber = firstNumber * 10 + thirdNumber;
	Console.WriteLine("Вторая цифра числа: " + secondNumber);
	Console.WriteLine("Число без второй цифры: " + newNumber);
}

FindNewDigit(number);