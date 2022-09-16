Console.WriteLine("Напишите два числа");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Наибольшим числом является  " + number1);
    Console.WriteLine("Наименьшим числом является  " + number2);
}
else if (number2 > number1)
{
    Console.WriteLine("Наибольшим числом является " + number2);
    Console.WriteLine("Наименьшим числом является " + number1);
}
else 
{
    Console.WriteLine( "Принятые числа равны равны"); // Немного не допонял задание и сделал программу работающую под любые числа. ( не знаю будет это за ошибку или нет)
}