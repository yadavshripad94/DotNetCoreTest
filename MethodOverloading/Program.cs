class Program
{
    static void Main()
    {
        Calculator c=new Calculator();
        Console.WriteLine(c.Add(10,20));
        Console.WriteLine(c.Add(10,20,30));
        Console.WriteLine(c.Add(10.5, 20.5));
        Console.WriteLine(c.Add(10.5m, 20.5m));
        Console.ReadLine();
    }
}
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }
}