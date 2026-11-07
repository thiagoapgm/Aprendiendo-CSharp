class Listas
{



    public void datos()
    {
        List<string> lista = new List<string>();
        lista.Add("Juan");
        lista.Add("abril");
        lista.Add("santino");
        

        foreach (string nombre in lista)
        {
            Console.WriteLine($"{nombre}");
        }

        Console.WriteLine("--------------------------------");

        List<int> edades = new List<int>();
        edades.Add(32);
        edades.Add(15);
        edades.Add(12);
        foreach(int edad in edades)
        {
            Console.WriteLine($"{edad}");
        }

         Console.WriteLine("--------------------------------");

        Console.WriteLine("posicion 15 removida");

         Console.WriteLine("--------------------------------");

        edades.Remove(15);
        foreach(int edad in edades)
        {
            Console.WriteLine($"{edad}");
        }

        Console.ReadKey();
    }


    public static void Main(string[] args)
    {
     Listas lista1 = new Listas();

     lista1.datos();
     
    }
}
