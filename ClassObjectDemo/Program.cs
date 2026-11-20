class Program
{
    static void Main()
    {
        Console.WriteLine("Main Method Start ...");
        
        Student s1= new Student();
        s1.FirstName = "Adam";
        s1.LasttName = "Hood";
        s1.PrintFullName();

        Student s2 = new Student();
        s2.FirstName = "Sam";
        s2.LasttName = "Ron";
        s2.PrintFullName();

        Student s3= new Student() { FirstName="Karan",LasttName="Kadam"};
        s3.PrintFullName();

        Console.WriteLine("Main Method End here ...");
        Console.ReadLine();
    }

    class Student
    {
       public string FirstName;
       public string LasttName;

       public void PrintFullName()
        {
            Console.WriteLine($"FullName : {FirstName} {LasttName}");
        }
    }
}