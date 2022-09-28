class Assignment_31
{
    public static void Main()
    {
        int first_side, second_side, third_side;
        Console.WriteLine("Enter the length of the first side:");
        first_side = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the second side:");
        second_side = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the third side:");
        third_side = int.Parse(Console.ReadLine());
        if (first_side + second_side > third_side && first_side + third_side > second_side && third_side + second_side > first_side)
            Console.WriteLine("It is a trinagle!");
        else
            Console.WriteLine("It isn't a trinagle!");
    }
}