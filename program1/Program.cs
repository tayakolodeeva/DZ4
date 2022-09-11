// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов
int DegreeOfNumber (int num1, int num2)
{
int degree = num1;  
for (int i = 1; i < num2; i++ )
{
degree = (degree * num1);
}
{
   return degree;
}
}


Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (степень):");
int num2 = Convert.ToInt32(Console.ReadLine());

int degreenum = DegreeOfNumber (num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} = {degreenum}");