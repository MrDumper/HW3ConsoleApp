int sum = 0;

Console.WriteLine("Введите кол-во ваших карт: ");

int numOfCards = Convert.ToInt32(Console.ReadLine());

for  (int i = 0; i < numOfCards; i++)
{
    Console.WriteLine("Введите обозначение вашей карты: ");
    var card = Console.ReadLine();

    if (int.TryParse(card, out int j))
    {
        sum += j;
    } else
    {
        switch(card)
        {
            case "J": sum += 10; break;
            case "Q": sum += 10; break;
            case "K": sum += 10; break;
            case "A": sum += 10; break;
            default: Console.WriteLine("Карты с таким номиналом не существует."); break;
        }
    }
}

Console.WriteLine($"Сумма твоих карт = {sum}");