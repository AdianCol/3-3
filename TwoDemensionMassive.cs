public interface ITwoDemensionMassive : IMassive
{
    void Snake();
}

public sealed class TwoDemensionMassive : Massive, IOneDemensionMassive
{
    private int[,] massive;

    public TwoDemensionMassive(bool choice = false): base(choice)
    {
    }

    public virtual void Snake()
    {
        Console.WriteLine("Rows in reverse order:");
        int s = massive.GetLength(0);
        int c = massive.GetLength(1);
        int j = 0;
        for (int i = 0; i < s; i++)
        {
            if (i % 2 == 0)
            {
                j = c-1;
                for (; j >-1; j--)
                {
                    Console.Write(massive[i, j] + " ");
                }
            }
            else
            {
                j = 0;
                for (; j < c; j++)
                {
                    Console.Write(massive[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    public override void CreateMassiveByUser()
    {
        int rows = (int)(Console.ReadLine());
        int columns = (int)(Console.ReadLine());
        array = new int[rows, columns];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
        }
    }

    public override void CreateMassive()
    {
        Console.WriteLine("Array length by string in format: len1 len2");
        string[] a = Console.ReadLine().Split();
        massive = new int[int.Parse(a[0]), int.Parse(a[1])];
        var random = new Random();
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                massive[i, j] = random.Next(-200, 200);
            }
        }
    }

    public override void AverageValue()
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                sum += massive[i, j];
                count++;
            }
        }
        Console.WriteLine("Average "+sum / count);
    }
    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            Console.Write($"Row {i}: ");
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                Console.Write(massive[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}