

Console.WriteLine("Добро пожаловать в Black Jack!!! \n \n Введите количество ваших карт:");
int Number = int.Parse(Console.ReadLine());

int Sum = 0;
int CardNumber = 0;
int intvalue;

while (CardNumber < Number)
{
    Console.WriteLine("Введите номинал вашей следующей карты");
    string strvalue = Console.ReadLine().ToUpper();

    switch (strvalue)
    {
        case "1":
            intvalue = 1;
            break;
        case "2":
            intvalue = 2;
            break;
        case "3":
            intvalue = 3;
            break;
        case "4":
            intvalue = 4;
            break;
        case "5":
            intvalue = 5;
            break;
        case "6":
            intvalue = 6;
            break;
        case "7":
            intvalue = 7;
            break;
        case "8":
            intvalue = 8;
            break;
        case "9":
            intvalue = 9;
            break;
        case "10":
            intvalue = 10;
            break;
        case "J":
            intvalue = 10;
            break;
        case "Q":
            intvalue = 10;
            break;
        case "K":
            intvalue = 10;
            break;
        case "T":
            intvalue = 10;
            break;

        default:
            intvalue = 0;
            break;
    }

    Sum += intvalue;
    CardNumber++;





}

Console.WriteLine($"Сумма ваших карт {Sum}");
Console.ReadKey();