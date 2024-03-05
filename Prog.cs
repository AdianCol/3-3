using System;

class Prog{
    static void Main(){
        IPrinter[] m = new IPrinter[]
        {
            new Week(),
            new OneDemensionMassive(),
            new TwoDemensionMassive(),
            new JaggedMassive()
        };
        foreach (var i in m){
            if(i is IMassive)
            {
                ((IMassive)i).CreateMassive();
                ((IMassive)i).Print();
                ((IMassive)i).AverageValue();
                if (i is IOneDemensionMassive)
                {
                    ((IOneDemensionMassive)i).DeleteDuplicates();
                    i.Print();
                }
                else if (i is TwoDemensionMassive)
                {
                    ((TwoDemensionMassive)i).Snake();
                }
                else if (i is IJaggedMassive)
                {
                    ((IJaggedMassive)i).ChangeChet();
                    i.Print();
                }
            }
            else
            {
                i.Print();
            }
        }
    }
}