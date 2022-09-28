class Assignment_27
{
    public static void Main()
    {
        Console.WriteLine("Enter a letter/ digit/ symbol:");
        char input = char.Parse(Console.ReadLine());
        if (input >= 'a' && input <= 'z')
            Console.WriteLine("You entered a letter!");
        else
            Console.WriteLine("You didn't enter a letter!");
    }
}