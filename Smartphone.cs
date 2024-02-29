namespace Task1;
public class Smartphone : Computer
{
     public Smartphone(int ram, int storage, string keyboard):base(ram,storage,keyboard)
     {
        Ram = ram;
        Storage = storage;
        Keyboard = keyboard;
     }
     private int _weight;
     public int Weight
     {
         get {return _weight;}
          set {_weight = value;} 
         }

    private int _battary;
     public int Battary
    {
         get {return _battary;}
         set {_battary = value;} 
    }
    public void WeightCheck()
    {
        if(_weight>100)System.Console.WriteLine("The weight is more than 100kg!");
        else System.Console.WriteLine("The weight is less than 100kg!");
    }
    public void BattaryCheck()
    {
        if(Battary>4000)System.Console.WriteLine("This is good telephone!");
        else System.Console.WriteLine("You must by new telephone!");
    }
}