class Personaje
{
    public string nombre;
    public int edad;
    public int fuerza;

//metodo constructor con parametros
    public Personaje(string nombre, int edad, int fuerza)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.fuerza = fuerza;
    }

    public static void Main()
    {
        Personaje personaje1 = new Personaje("thiago", 25, 10);

        Console.WriteLine("Nombre: " + personaje1.nombre);
        Console.WriteLine("Edad: " + personaje1.edad);  
        Console.WriteLine("Fuerza: " + personaje1.fuerza);
    }
}