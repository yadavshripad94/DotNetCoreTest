class Program
{
     static void Main()
     {
        // Method 1: Declare and initialize together
        int[] numbers = { 10, 20, 30, 40 };
        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(numbers[3]);

        Console.WriteLine("-------------------------");
        //Method 2: Using the new keyword
        int[] numbers1 = new int[5];
        numbers1[0] = 12;
        numbers1[1] = 13;
        numbers1[2] = 14;
        numbers1[3] = 15;
        Console.WriteLine(numbers1[0]);

        Console.WriteLine("-------------------------");

        //Method 3: Initialize using new with values
        int[] numbers2 = new int[] { 21, 22, 33, 44 };

        //find array length
        Console.WriteLine(numbers2.Length);




        Console.ReadLine();
    }
}