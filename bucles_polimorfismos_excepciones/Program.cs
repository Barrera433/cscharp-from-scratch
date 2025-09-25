var circ = new Circulo();

circ.Radio = 20;
var result_area = circ.Area();
var result_perimetro = circ.Perimetro();

Console.WriteLine($" El Area es: {result_area}");
Console.WriteLine($" El Perimetro es: {result_perimetro}");


int prev = 0;
int next = 1;
int sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

try
{
    Console.WriteLine(" numero a dividir:");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine(" numero divisor:");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException(" No se puede dividir por cero");
    }

    Console.WriteLine($" El resultado es: {n / divisor}");
}
catch (DivideByZeroException ex) when (ex.Message.Contains("cero"))
{
    Console.WriteLine(" no se puede dividir por cero");
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine(" Error generico");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine(" Gracias por usar el programa");
}

interface IExtrCalculations
{
    public double Add10();
}
class Circulo : IExtrCalculations
{
    public double Radio { get; set; }

    public double Area() => Math.PI * Math.Pow(Radio, 2);

    public double Perimetro() => 2 * Math.PI * Radio;

    public double Add10() => Area() + 10;
}