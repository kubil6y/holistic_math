namespace AppSpace;

public class App
{
    static public int MAGIC = 16;
    static public int INTELLIGENCE = 8;
    static public int CHARISMA = 4;
    static public int FLY = 2;
    static public int INVISIBLE = 1;
    public int Attributes = 0;

    public void AddMagicInt()
    {
        Console.WriteLine("Add INTELLIGENCE, MAGIC");
        this.Attributes |= (MAGIC | INTELLIGENCE);
    }

    public void AddMagic()
    {
        Console.WriteLine("Add MAGIC");
        this.Attributes |= MAGIC ;
    }

    public void RemoveInt()
    {
        Console.WriteLine("Remove INTELLIGENCE");
        this.Attributes &= ~INTELLIGENCE;
    }

    public void RemoveMagic()
    {
        Console.WriteLine("Remove MAGIC");
        this.Attributes &= ~MAGIC;
    }

    public void Reset()
    {
        Console.WriteLine("RESET");
        this.Attributes = 0;
    }

    // Bit Masking
    public void HasMagic()
    {
        // These two are the same thing.
        //var hasMagic = (this.Attributes & MAGIC) != 0;
        var hasMagic = (this.Attributes & MAGIC) == MAGIC;
        Console.WriteLine($"Has Magic? {hasMagic}");
    }

    public void PrintBinary()
    {
        Console.WriteLine($"\t{Convert.ToString(this.Attributes, 2).PadLeft(5, '0')}");
    }
}
