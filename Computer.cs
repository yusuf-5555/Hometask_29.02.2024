namespace Task1;
public class Computer
{
    private int _ram;
    public int Ram 
    {
        get {return _ram; }
        set {_ram = value; } 
    }
    private int _storage;
    public int Storage
    {
        get {return _storage; }
        set {_storage = value; } 
    }
    private string _keyboard;
    public string Keyboard 
    {
        get {return _keyboard; }
        set {_keyboard = value; } 
    }

    public Computer(int ram, int storage, string keyboard)
    {
        Ram = ram;
        Storage = storage;
        Keyboard = keyboard;
    }

    public void AddRam(int ram)
    {
        Ram = ram;
    }
    public void AddStorage(int storage)
    {
        Storage = storage;
    }
}