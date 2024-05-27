int minNum = int.MaxValue;

Console.WriteLine("Введите длину последовательности чисел");

int lenght = Convert.ToInt32(Console.ReadLine());

for  (int i = 0; i < lenght; i++)
{
    Console.WriteLine("Введите элемент последовательности: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < minNum)
    {
        minNum = num;
    }
}

Console.WriteLine($"Минимальный элемент в последовательности = {minNum}");

Console.ReadKey();