class Calculo
{

    public int a;

    public int b;
    public int suma()
    {
        return a + b;
    }
    public int resta()
    {
        return a - b;
    }

    public static void Main()
    {
        Calculo c = new Calculo();

        Console.WriteLine("Ingrese el primer número:");
        c.a = int.TryParse(Console.ReadLine(), out int aValue) ? aValue : 0;

        if (c.a == 0)
        {
            Console.WriteLine("número ingresado no válido. por favor, ingrese un número entero.");

            while (c.a == 0)
            {
                Console.WriteLine("Ingrese el primer número:");
                c.a = int.TryParse(Console.ReadLine(), out aValue) ? aValue : 0;
                if (c.a == 0)
                {
                    Console.WriteLine("número ingresado no válido. por favor, ingrese un número entero.");
                }
            }

        }



        Console.WriteLine("Ingrese el segundo número:");
        c.b = int.TryParse(Console.ReadLine(), out int bValue) ? bValue : 0;
        if (c.b == 0)
        {
            Console.WriteLine("número ingresado no válido. por favor, ingrese un número entero.");

            while (c.b == 0)
            {
                Console.WriteLine("Ingrese el segundo número:");
                c.b = int.TryParse(Console.ReadLine(), out bValue) ? bValue : 0;
                if (c.b == 0)
                {
                    Console.WriteLine("número ingresado no válido. por favor, ingrese un número entero.");
                }
            }

        }

       Console.WriteLine("ingrese la operacion a realizar: ");

       string operacion = Console.ReadLine() ?? "";
       if(operacion.ToLower().Trim() == "suma" || operacion.Trim() == "+" )
       {
            Console.WriteLine("El resultado de la suma es: " + c.suma());
       }
       else if(operacion.ToLower().Trim() == "resta" || operacion.Trim() == "-" )
       {
            Console.WriteLine("El resultado de la resta es: " + c.resta());
       }
        else
       {
            Console.WriteLine("Operación no válida.");
       }
    }
}