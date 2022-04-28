// See https://aka.ms/new-console-template for more information


class Homework6
{
    static void Main(string[] args)
    {
    
        Celsius(50);
        ShowCharacter("tennessee", 4);
        CalculateRetail(50,100);
        IsPrime(5);

    }
    static void ShowCharacter(string state, int num)
    {
     Console.WriteLine(state[num+1]);
    }
static void CalculateRetail(double cost, double markup)
{
    double extra = (markup/100)*cost;
    double price = cost+extra;
    Console.WriteLine($"The retail price of the item is $"+price+".");
}

static void Celsius(int far)
{
    int temp = 5/9*(far-32);
    Console.WriteLine("equals" + temp + "degrees");
}

static void IsPrime(int number)
{
    if (number == 1) 
    {
        Console.WriteLine(false);
    }
    if (number == 2) 
    {
        Console.WriteLine(true);
    }
    if(number % 2 == 0)
    {
        Console.WriteLine(false);
    } 
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine(false);
        } 
    }
    Console.WriteLine(true);
}


}























