

using static System.Console;

WriteLine("Введите число: ");

//Введём число и сконвертируем его в нужный тип
int number = Convert.ToInt32(ReadLine());

//В задании написано с 1, но зачем, если на 1 делится вообще любое число даже не простое, так что начнем с 2
int i = 2; 
bool simpleNumber = true;

while (i < number - 1)
{
    if (number % i == 0)
    {
        simpleNumber = false;
        break; //Если делится на любое другое число - то всё, можно прерывать
    }
    i++;
}

WriteLine(simpleNumber?"Число является простым":"Число не является простым");

ReadKey();