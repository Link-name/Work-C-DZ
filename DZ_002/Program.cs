Console.WriteLine("Пожалуйста введите 3 любых числа");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
int Max = 0;
if (number1 > number2)
{
    Max = number1;
}
else
{
    Max = number2;
}
if (Max > number3)
{
    Console.WriteLine("Максимальное число будет   " + Max);
}
else
{
    Max = number3;
    Console.WriteLine("Максимальным числом будет  " + Max);
} 
