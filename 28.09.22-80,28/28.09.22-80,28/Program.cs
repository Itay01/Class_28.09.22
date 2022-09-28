class Assignment_28
{
    public static void Main()
    {
        Console.WriteLine("Enter the number of students:");
        int students = int.Parse(Console.ReadLine());
        if (students % 2 == 0 && students % 3 == 0 && students % 4 == 0)
            Console.WriteLine("Your class is not like Shushi's");
        else
            Console.WriteLine("Your class is like Shushi's");
    }
}