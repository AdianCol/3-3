public abstract class Massive : IMassive
{
    public abstract void CreateMassive();

    public abstract void CreateMassiveByUser();

    public abstract void AverageValue();

    public abstract void Print();

    public Massive(bool choice)
    {
        if(choice)
        {
            CreateMassiveByUser();
        }
        else
        {
            CreateMassive();
        }
    }
}


public interface IMassive : IPrinter
{
    void CreateMassive();

    void CreateMassiveByUser();

    void AverageValue();

    void Print();
}