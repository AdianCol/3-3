
public interface IOneDemensionMassive : IMassive
{
    void DeleteDuplicates();
}

public sealed class OneDemensionMassive : Massive, IOneDemensionMassive
{
    private int[] massive;


    public OneDemensionMassive(bool choice = false): base(choice)
    {
    }

    public virtual void DeleteDuplicates()
    {
        int n = massive.Length;
        for (int i = 0; i < massive.Length; i++)
        {
            for (int it = 0; it < massive.Length; it++)
            {
                if (massive[i] == massive[it] && it != i && it > i)
                {
                    n--;
                }
            }
        }
        int[] newArray = new int[n];
        int newIndex = 0;
        for (int i = 0; i < massive.Length; i++)
        {
            bool isDuplicate = false;
            for (int it = 0; it < i; it++)
            {
                if (massive[i] == massive[it])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                newArray[newIndex] = massive[i];
                newIndex++;
            }
        }
        massive = newArray;
    }

    public override void CreateMassiveByUser()
    {
        int length = (int)(Console.ReadLine());
        array = new int[length];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public override void CreateMassive()
    {
        Console.WriteLine("Array length");
        massive = new int[int.Parse(Console.ReadLine())];
        var random = new Random();
        for (int i = 0; i < massive.Length; i++)
        {
            massive[i] = random.Next(-200, 200);
        }
    }

    public override void AverageValue()
    {
            Console.WriteLine("Average "+massive.Average());
    }
    public override void Print()
    {
        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(" ", massive));
    }
}