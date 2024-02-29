namespace Task1;
public class Laptop : Computer
{
     public Laptop(int ram, int storage, string keyboard):base(ram,storage,keyboard)
     {
        Ram = ram;
        Storage = storage;
        Keyboard = keyboard;
     }
     private int _numberofselfies=0;
     public int NumberOfSelfies 
     {
         get {return _numberofselfies;}
          set {_numberofselfies = value;} 
         }
          private int _display;
     public int Display
     {
         get {return _display;}
          set {_display = value;} 
         }
    public void TakeSelfies()
    {
        _numberofselfies++;
    }
    public void DisplaySize()
    {
        if(_display>14)System.Console.WriteLine("Diplay is big");
        else System.Console.WriteLine("Display is small");
    }
}