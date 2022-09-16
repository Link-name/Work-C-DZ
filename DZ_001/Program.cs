Console.WriteLine("Напишите два числа");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Большим числом является  " + number1);
    Console.WriteLine("Наименьше число является  " + number2);
}
else if (number2 > number1)
{
    Console.WriteLine("Наибольше число является " + number2);
    Console.WriteLine("Наименьше число является " + number1);
}
else 
{
    Console.WriteLine( "Принятые числа равны равны"); // Немного не допонял задание и сделал программу работающую под любые числа. ( не знаю будет это за ошибку или нет)
}