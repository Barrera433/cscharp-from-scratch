
/*clases*/
var cuard = new cuadrado { Base = 5, Altura = 10 };
Console.WriteLine($" El Area es: {cuard.Area()}");
Console.WriteLine($" El Perimetro es: {cuard.Perimetro()}");
/*End clases*/


class rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double Area() => Base * Altura;

    public double Perimetro() => 2 * (Base + Altura);

}

class cuadrado : rectangulo
{
    public double Lado
    {
        set
        {
            Base = value;
            Altura = value;
        }
        get { return Base; }
    }
}

/*var cuard = new cuadrado();
cuard.Base = 20;
cuard.Altura = 40;
Console.WriteLine($" El Area es: {cuard.Area()}");
Console.WriteLine($" El Perimetro es: {cuard.Perimetro()}");
Console.WriteLine($" El Lado es: {cuard.Lado}");*/