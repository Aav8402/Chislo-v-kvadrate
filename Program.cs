// Напишите программу, которая на вход принимает число и
// выдает его квадрат (число умноженное само на себя).
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Результат " + result);

if (num == result)
{
    Console.WriteLine($"Не может такого быть!!!!");
}
else
{
    Console.WriteLine($"Да");
}