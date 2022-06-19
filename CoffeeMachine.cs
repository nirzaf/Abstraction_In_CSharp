namespace Abstraction_In_CSharp;

public abstract class CoffeeMachine
{
     public abstract void MakeExpresso();
     public abstract void MakeCappucino();
     public abstract void MakeCoffee();
}

public class Coffee
{
     public void MakeCoffee()
     {
          Console.WriteLine("Making coffee");
     }
}

public class MakeCoffeeWithMilk : Coffee
{
     public void MakeCoffee()
     {
          Console.WriteLine("Making coffee with milk");
     }
}

internal class EspressoMachine : CoffeeMachine
{
     public override void MakeExpresso()
     {
          Console.WriteLine("Add Water");
          Console.WriteLine("Add Espresso");
          Console.WriteLine("Add Milk");
          Console.WriteLine("Add Sugar");
          Console.WriteLine("Add Cream");
          Console.WriteLine("Making Espresso....");
          Console.WriteLine("Espresso is ready");
     }
     public override void MakeCappucino()
     {
          Console.WriteLine("Making Cappucino");
     }
     public override void MakeCoffee()
     {
          Console.WriteLine("Making Coffee");
     }
}

public abstract class Printer
{
     public abstract void Print(string input);
     public abstract void Scan();
     public abstract int TotalPrintCopies();
}

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