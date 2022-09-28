class Assignment_26
{
    public static void Main()
    {
        int age, experience_years;
        Console.WriteLine("Enter your age:");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your years of experience:");
        experience_years = int.Parse(Console.ReadLine());
        if (age >= 35 && age <= 45 && experience_years >= 3)
            Console.WriteLine("Call us!");
        else
            Console.WriteLine("Sorry, good luck next time!");
    }
}