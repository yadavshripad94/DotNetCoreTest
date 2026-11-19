class Program
{
    static void Main()
    {
        int[] number = {1,2,3,4,5};
        for(int i=number.Length-1;i>=0; i--)
        {
            Console.Write(number[i]);
        }

        Console.ReadLine();
    }
}