Console.WriteLine("Введи максимальное число в диапазоне: ");

int maxValue = Convert.ToInt32(Console.ReadLine());

Random random = new Random();

int numberToSolve = random.Next(0, maxValue);

int tries = 0;

while(true)
{
    tries++;
    Console.WriteLine("Введите число: ");
    if(int.TryParse(Console.ReadLine(), out int userNum))
    {
        if(userNum < numberToSolve)
        {
            Console.WriteLine("Ваше число меньше загаданного.");
        }
        else if(userNum > numberToSolve) {
            Console.WriteLine("Ваше число больше загаданного.");
        }
        else
        {            
            Console.WriteLine($"Вы угадали! Загаданное число = {numberToSolve}. Число попыток = {tries}");
            break;
        }
    } else
    {
        break;
    }
}