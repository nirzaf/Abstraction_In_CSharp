namespace Abstraction_In_CSharp;

public class Canon : Printer
{
    public override void Print(string input)
    {
        Console.WriteLine($"Printing {input} in Black & White");
    }

    public override void Scan()
    {
        Console.WriteLine("Scanning document with 300 DPI");
    }

    public override int TotalPrintCopies()
    {
        return 200;
    }
}