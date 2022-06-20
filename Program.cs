using Abstraction_In_CSharp;

MakeCoffeeWithMilk makeCoffeeWithMilk = new ();
MakeCoffeeWithMilk.MakeCoffee();
Coffee coffee = new();
coffee.MakeCoffee();

Epson ep = new();
ep.Print(" Assignment Document ");
ep.PrintInBlackAndWhite("Page 1");

Canon can = new();
can.Print(" Image ");

Console.ReadKey();