using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int deleteValue = 30;

        int count = 0;

        // Count elements that should remain
        for(int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != deleteValue)
            {
                count++;
            }
        }

        int[] newArray = new int[count];
        int index = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != deleteValue)
            {
                newArray[index] = numbers[i];
                index++;
            }
        }

        foreach (int number in newArray)
        {
            Console.Write(number + " ");
        }

        Console.ReadLine();
    }
}