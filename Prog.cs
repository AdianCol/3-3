using System;

class Prog{
    static void Main(){
        Massive[] m = new Massive[3];
        m[0] = new OneDemensionMassive(1);
        m[1] = new TwoDemensionMassive(1 ,1);
        m[2] = new JaggedMassive(1);
        foreach (var i in m){
            i.CreateMassive();
            i.Print();
            i.AverageValue();
        }
    }
}