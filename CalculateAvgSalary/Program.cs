class Program
{
    static void Main()
    {
        int[] salaries = { 25000, 30000, 35000, 40000, 45000 };
        int total = 0;

        Console.WriteLine("Employee Salaries : ");
        for(int i=0; i<salaries.Length; i++)
        {
            Console.WriteLine($"Employee {i+1} : {salaries[i]}");
            total += salaries[i];
        }
        double average = (double)total / salaries.Length;

        Console.WriteLine($"Total Salary: {total}");
        Console.WriteLine($"Average Salary: {average}");

        Console.ReadLine();
    }
}