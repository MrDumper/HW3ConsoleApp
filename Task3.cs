Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

bool flag = false;

for  (int i = 2;  i <= num - 1; i++)
{
    if (num % i == 0)
    {
        flag = true;
        break;
    }
}

if (flag)
{
    Console.WriteLine($"Число {num} не является простым.");
}
else
{
    Console.WriteLine($"Число {num} простое");
}

Console.ReadKey();