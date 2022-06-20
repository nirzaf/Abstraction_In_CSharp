namespace Abstraction_In_CSharp;

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