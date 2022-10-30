namespace WithFlagsSpace;

[Flags]
public enum MyFlags
{
    None = 0,
    INVISIBLE = 1,
    FLY = 2,
    CHARISMA = 4,
    INTELLIGENCE = 8,
    MAGIC = 16,
}

public class WithFlags
{
    public MyFlags Attributes = MyFlags.None;

    public void AddMagicInt()
    {
        Console.WriteLine("Add INTELLIGENCE, MAGIC");
        this.Attributes |= (MyFlags.MAGIC | MyFlags.INTELLIGENCE);
    }

    public void RemoveInt()
    {
        Console.WriteLine("Remove INTELLIGENCE");
        //this.Attributes &= ~INTELLIGENCE;
        this.Attributes &= ~MyFlags.INTELLIGENCE;
    }

    public void RemoveMagic()
    {
        Console.WriteLine("Remove MAGIC");
        this.Attributes &= ~MyFlags.MAGIC;
    }

    public void Reset()
    {
        Console.WriteLine("RESET");
        this.Attributes = MyFlags.None;
    }

    public void HasMagic()
    {
        var hasMagic = this.Attributes.HasFlag(MyFlags.MAGIC);
        Console.WriteLine($"Has Magic? {hasMagic}");
    }

    public void PrintBinary()
    {
        System.Console.WriteLine(this.Attributes);
        //Console.WriteLine($"\t{Convert.ToString(this.Attributes, 2).PadLeft(5)}");
    }
}
