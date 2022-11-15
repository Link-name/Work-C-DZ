Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
int number2 = 1;
while (number2 <= number)
{

    if (number2 % 2 == 0)
    {
        Console.Write( +number2 + " " );
        number2++;
    }
    else
    {
        number2++;
    }
}
