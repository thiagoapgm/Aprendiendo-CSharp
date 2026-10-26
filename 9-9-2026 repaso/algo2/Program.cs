
using System.Diagnostics.Contracts;

class Personajes
{
    int edad = 18;
    string nombre = "thaigo"; 
    bool mayor_de_edad = true;
    float altura = 1.69f;
    static void Main()
    {
        Personajes persona = new Personajes ();
        Console.WriteLine($"La edad de la persona es : {persona.edad} \n" +
        $"El nombre de la persona es: {persona.nombre} \n" +
        $"¿La persona es mayor de edad? : {persona.mayor_de_edad}  \n" +
        $"La persona mide de aproximado : {persona.altura}" );
    }
    
}