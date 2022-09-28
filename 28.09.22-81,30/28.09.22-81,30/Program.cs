class Assignment_30
{
    public static void Main()
    {
        int first_age, second_age;
        char first_gender, second_gender;
        Console.WriteLine("Enter the first age:");
        first_age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first gender (m/ f):");
        first_gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first age:");
        second_age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first gender (m/ f):");
        second_gender = char.Parse(Console.ReadLine());
        if ((first_age - second_age <= 5 || first_age - second_age <= -5) && (first_gender == 'm' && second_gender == 'f' || first_gender == 'f' && second_gender == 'm'))
            Console.WriteLine("Perfect match!");
        else
            Console.WriteLine("Keep trying!");
    }
}