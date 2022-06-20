namespace Abstraction_In_CSharp;

public class Epson : Printer
{
    public override void Print(string input)
    {
        Console.WriteLine($"Printing {input} in Color");
    }

    public override void Scan()
    {
        Console.WriteLine("Scanning document with 600 DPI");
    }
     
    public void PrintInBlackAndWhite(string input)
    {
        Console.WriteLine($"Printing {input} in Black and White");
    }

    public override int TotalPrintCopies()
    {
        return 100;
    }
}