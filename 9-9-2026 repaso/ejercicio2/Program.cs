class Calculador
{
    
    public string nombre = "thiago";
    public int a;

    public int b;
    public string pregunta;
    public bool? verificacion = false;
    
    public int sumas()
    {
        int suma = b+a;

        return suma;
        
    }

    public int restas()
    {
        int resta = a-b;

        return resta;
    }
    public static void Main()
    {
        Calculador calcula = new Calculador();
        Console.WriteLine("introduce el primer numero: "); 
        while(!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("introduce un munero solamente");
        }
        Console.WriteLine($"el numero elegido es {calcula.a}");  
    }





}