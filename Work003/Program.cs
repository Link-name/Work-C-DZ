
Console.WriteLine("Мы попали в игру угадай число");
int secret_number = new Random().Next(1, 5);
int attempt = 5;
bool Win = false;
while (attempt > 0)
{
    Console.WriteLine("Ввидете число от 1 до 10");
    int user_number = int.Parse(Console.ReadLine());

    if (secret_number < user_number)
    {
        Console.WriteLine("Вы не угадали.  ");
    }
    else if (secret_number > user_number)
    {
        Console.WriteLine("Вы не угадали.  ");
    }
    else
    {
        Console.WriteLine("Ура вы угадали !!!!");
        Win = true;
        break;
    }
    attempt--;

    Console.WriteLine("Попыток осталось   " + attempt);

}
if (Win)
{
    Console.WriteLine("Поздравляем вы победили жем вас сново ");
    Console.WriteLine("У вас осталось  " + (attempt - 1 ) + "  попыток");
}

else
{
    Console.WriteLine("Вы проиграли. Секретное число было   " + secret_number);
    Console.WriteLine("Ждем вас сново!!!");
}