
void PrintList<T>(List<T> list) where T : IFormattable
{
    Console.Write("[");
    foreach (var element in list)
    {
        Console.Write($"{element},");
    }
    Console.Write("\b] \n");
}

void Ex1()
{
    List<int> numbers = new();
    do
    {
        
        Console.WriteLine("Введіть число");
        int number = 0;
        while (!int.TryParse(Console.ReadLine(), out number) )
        {
            Console.WriteLine("Неправильне число");
        }

        if (number % 2 == 0) numbers.Insert(0, number);
        else numbers.Add(number);
        PrintList(numbers);
        Console.WriteLine("Продовжити? Так/Ні");
    } while (Console.ReadLine() is "так" or "");
}

void Ex2()
{
    Dictionary<string, double> dict = new()
    {
        {"item1", 45.50},
        {"item2",35},
        {"item3", 41.30 },
        {"item4",55 },
        {"item5", 24}
    };
    foreach (var pair in dict.OrderByDescending(pair => pair.Value).Take(3))
    {
        Console.WriteLine($"{pair.Key} - {pair.Value}");
    }
}

Console.WriteLine("Оберіть завдання 1,2");
var answer = Console.ReadLine();
if(answer=="1") Ex1();
else if(answer=="2") Ex2();