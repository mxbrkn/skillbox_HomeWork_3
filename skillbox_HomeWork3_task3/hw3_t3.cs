using static System.Console;

WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
int i = 2;
bool simpleNumber = true;

while (i < number - 1)
{
    if (number % i == 0)
    {
        simpleNumber = false;
        break;
    }
    i++;
}

WriteLine(simpleNumber?"Число является простым":"Число не является простым");

ReadKey();