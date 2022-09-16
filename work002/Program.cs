Console.WriteLine("Напишите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите число b");
int b = int.Parse(Console.ReadLine());


if (a > b)
{
    Console.WriteLine("Число a больше числа b");
}
else if (a < b )
{
 
    Console.WriteLine("Число b больше числа a");
}
else
{
    Console.WriteLine("Число b равно числу a");
}