class Assignment_25
{
    public static void Main()
    {
        int num;
        Console.WriteLine("Enter a number:");
        num = int.Parse(Console.ReadLine());
        if (num >= 0 && num < 10)
            Console.WriteLine("The number is single digit!");
        else
            Console.WriteLine("The number isn't single digit!");
    }
}