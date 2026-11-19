class Program
{
    static void Main()
    {
        //Find the second largest distinct number

        int[] numbers= { 10, 25, 8, 40, 15, 30, 7 };
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for(int i=0; i<numbers.Length; i++)
        {
            if(numbers[i] > largest)
            {
                secondLargest = largest;
                largest = numbers[i];
            }
            else if (numbers[i] > secondLargest && numbers[i] != largest)
            {
                secondLargest = numbers[i];
            }
        }
        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("Second largest does not exist.");
        }
        else
        {
            Console.WriteLine("Second Largest: " + secondLargest);
        }
        Console.ReadLine();
    }
}