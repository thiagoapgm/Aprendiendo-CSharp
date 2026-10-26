using System.Security.Cryptography.X509Certificates;

class Persona
{
    void Gente(string nombre, int edad)
    {
        Console.WriteLine($"el nombre es:  {nombre}  \n" +
    $"edad de la persona:  {edad}");
    }

    double Capital(double pasivo, double activo)
    {
        double PatrimonioNeto= pasivo - activo;

        return PatrimonioNeto;
    }


    public static void Main()
    {
        Persona usuario = new Persona();
        Console.WriteLine("ingrese tu nombre porfavor:");

        string? nombre = Console.ReadLine() ?? ""; 

        Console.WriteLine("ingrese su edad porfavor");

        string entrada = Console.ReadLine() ?? "";

        if(!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("error: solo se puede colocar numeros en esta seccion \n" +
            "intente de vuelta: ");
        }

        Console. WriteLine("ingrese la cantidad de activo que posee: ");

        
        double capitalTotal =  usuario.Capital(1209.12 , 23444.21);

        usuario.Gente(nombre, numero);
    }
}