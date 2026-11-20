class Program
{
    static void Main()
    {
        Printer p=new Printer();
        p.Start();
        p.Print();
        p.Scan();
        

        Console.ReadLine();
    }
}
interface IPrintable
{
    void Print();
}
interface IScanable
{
    void Scan();
}
interface IMachine:IPrintable,IScanable
{
    void Start();
}

class Printer:IMachine
{
    public void Print()
    {
        Console.WriteLine("Printing document");
    }
    public void Scan()
    {
        Console.WriteLine("Scanning document");
    }
    public void Start()
    {
        Console.WriteLine("Machine started");
    }
}