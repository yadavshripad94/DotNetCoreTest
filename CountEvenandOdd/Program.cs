class Program
{
    static void Main()
    {
        //Count even and odd numbers in an array

        int[] numbers = { 10, 25, 8, 40, 15, 30, 7 };

        int evenCount = 0;
        int oddCount = 0;

        for (int i=0; i<numbers.Length; i++)
        {
            if (numbers[i] % 2 ==0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine("Even Count : "+evenCount);
        Console.WriteLine("Odd Count : "+oddCount);
        Console.ReadLine();
    }
}