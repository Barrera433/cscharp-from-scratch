
namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
        
           DateOnly dateconverted = new DateOnly();
           string nameinput;
           string birthdayinput;
           Console.WriteLine("¡Hola Bienvenido a el calculador de años!");
            Console.WriteLine("Por favor ingrese su nombre:");
            nameinput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte:{nameinput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy:");
            birthdayinput = Console.ReadLine();
            bool isDatevalid = DateOnly.TryParse(birthdayinput, out dateconverted);
            if (!isDatevalid == false)
            {
                Console.WriteLine($"La fecha ingresada no es valida, por favor intente de nuevo. {birthdayinput}");
                var person = new Person
                {
                    Name = nameinput,
                    BirthDate = dateconverted,
                    Age = DateTime.Now.Year - dateconverted.Year
                };
                Console.WriteLine($"Tu nombre es: {person.Name}");
                Console.WriteLine($"Tu fecha de nacimiento es: {person.BirthDate}");
                Console.WriteLine($"Tu edad es: {person.Age} años");

                Console.ReadLine();
            
            }

                   
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}