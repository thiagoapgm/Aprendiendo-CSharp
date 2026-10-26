class Animales
{
    string nombre = "Thiago";
    int cantidad = 12;

    bool verificacion = true;

    string? entrada;

    string?[] animales = ["gato", "perro", "leon", "mono"];

    static void Main()
    {
        Animales son = new Animales();
        while (son.animales[0] == "gato" || son.cantidad > 10 )        
        {
            if(son.animales[0] == "gato")
            {
                Console.WriteLine($"Que lindo {son.animales[0]} pa' \n" + 
                $"Pero no podes pasar, {son.nombre}");

                son.animales[0] = Console.ReadLine();

                while(son.animales[0] == son.animales[1] || son.animales[0] == son.animales[2] || son.animales[0] == son.animales[3])
                {
                    Console.WriteLine($"NO puede repetir animales...");
                    
                    

                    son.animales[0] = Console.ReadLine();
                }
            }
            else if(son.cantidad > 10 )
            {
                Console.WriteLine($"La cantidad maxima de animales abordo son 10 \n" +
                "disculpe pero no puede pasar");

                son.entrada = Console.ReadLine();
                
                if(int.TryParse(son.entrada, out int cantidad1) )
                {
                    Console.WriteLine($"el numero es : {cantidad1}"); 

                    son.verificacion = false;
                    son.cantidad = cantidad1;
                }    
            }
        }
        Console.WriteLine($"pasa tranca, {son.nombre}");
    }   
}
