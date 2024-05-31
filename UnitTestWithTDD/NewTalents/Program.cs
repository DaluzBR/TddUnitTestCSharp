// See https://aka.ms/new-console-template for more information
using NewTalents.Models;

var c = new Calculator();

c.Sum(5, 7);
Console.WriteLine($"Soma: {c.ShowHistoric()[0]}");
c.Subtract(18, 8);
Console.WriteLine($"Subtração: {c.ShowHistoric()[0]}");
c.Multiply(3, 5);
Console.WriteLine($"Multiplicação: {c.ShowHistoric()[0]}");
c.Division(28, 7);
Console.WriteLine($"Divisão: {c.ShowHistoric()[0]}");
try
{
    c.Division(28, 0);
}
catch (ArithmeticException e)
{
    Console.WriteLine($"Divisão: {e.Message}");
}

