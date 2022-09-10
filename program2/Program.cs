// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumOfDigits (int num)
{
int quantity = Convert.ToString(num).Length;
int number = 0;
int sum = 0;
for (int i = 0; i < quantity; i++)
{
number = num - num % 10;
sum = sum + (num - number);
num = num / 10;
}
{
return sum;
}
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits (num);
Console.WriteLine($" Сумма цыфер числа {num} = {sum}");
