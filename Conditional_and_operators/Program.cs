
/*Conditional*\
Console.WriteLine("ingrese un numero:");
int num = int.Parse(Console.ReadLine());
if (num > 0) Console.WriteLine("el numero es positivo");
else if (num < 0) Console.WriteLine("el numero es negativo");
else Console.WriteLine("el numero es cero");

/*End Conditional*\


\*Operators*/
Console.WriteLine("ingrese un numero:");
string inputA = Console.ReadLine();
double a;
while (!double.TryParse(inputA, out a))
{
    Console.WriteLine("Entrada inválida. Por favor, ingrese un número:");
    inputA = Console.ReadLine();
}

Console.WriteLine("ingrese segundo numero:");
string inputB = Console.ReadLine();
double b;
while (!double.TryParse(inputB, out b))
{
    Console.WriteLine("Entrada inválida. Por favor, ingrese un número:");
    inputB = Console.ReadLine();
}

Console.WriteLine("suma: " + (a + b));
Console.WriteLine("resta: " + (a - b));
Console.WriteLine("multiplicacion: " + (a * b));
Console.WriteLine("division: " + (b != 0 ? (a / b) : double.NaN)); // Uso de double.NaN para indefinido
Console.WriteLine("modulo: " + (a % b));
    
/*End Operators*/