Console.WriteLine("Напишите любое число и мы скажем четное или оно");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine( number + "   Это число является четным");
}
else 
{
    Console.WriteLine( "   Увы введенное число не является четным");
}