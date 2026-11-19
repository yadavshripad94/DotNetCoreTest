class Program
{
    static void Main()
    {
        //Print all even numbers from an integer array
        int[] numbers = { 10, 25, 8, 40, 15, 30, 7 };
        for(int i=0; i<numbers.Length; i++)
        {
            if (numbers[i] %2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        Console.ReadLine();
    }
}