using System;

public interface IPrinter
{
    void Print();
}

public class Week: IPrinter
{
    private string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}; 
    public void Print()
    {
        foreach(string i in days)
        {
            Console.WriteLine(i);
        }
    }
}