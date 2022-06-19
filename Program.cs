// See https://aka.ms/new-console-template for more information

using Abstraction_In_CSharp;

MakeCoffeeWithMilk makeCoffeeWithMilk = new ();
makeCoffeeWithMilk.MakeCoffee();
Coffee coffee = new();
coffee.MakeCoffee();

Epson ep = new();
ep.Print(" Assignment Document ");
ep.PrintInBlackAndWhite("Page 1");

Canon can = new();
can.Print(" Image ");



Console.ReadKey();