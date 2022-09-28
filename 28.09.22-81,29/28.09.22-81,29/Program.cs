class Assignment_29
{
    public static void Main()
    {
        int first_num, second_num, third_num;
        Console.WriteLine("Enter the first number:");
        first_num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        second_num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        third_num = int.Parse(Console.ReadLine());
        first_num *= first_num;
        second_num *= second_num;
        third_num *= third_num;
        if (first_num + second_num == third_num || first_num + third_num == second_num || second_num + third_num == second_num)
            Console.WriteLine("It is Pythagorean triple!");
        else
            Console.WriteLine("It isn't Pythagorean triple!");
    }
}