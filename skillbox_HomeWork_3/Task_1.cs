
Console.WriteLine("Введите число: ");

//Искренне надеемся, что пользователь введет именно число
//Исключения будем обрабатывать когда-то потом
int number = int.Parse(Console.ReadLine());

//Будем конструировать слово в зависимости от условий
string resultWord = "четным";

if (number%2 > 0)
{
    resultWord = "не" + resultWord;
}

//Сообщаем результат
Console.WriteLine($"Число является {resultWord}");
Console.ReadKey();
