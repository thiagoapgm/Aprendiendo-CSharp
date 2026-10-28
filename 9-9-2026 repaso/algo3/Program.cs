class Prueba
{
    public string nombre = "thiago";
    void saludo() //Metodo sin retorno
    {
        Console.WriteLine($"Hola {nombre}, Buenos dias...");
    }
    public int sumar() //Metodos con retorno
    {
        int valor1=12,valor2=22,resultado;
        resultado=valor1 + valor2;
        return resultado;
    }
    public string despedir() //Metodo con retorno
    {
        string despedida = "Adios a todos, manga de putos";
        return despedida;
    }
    public static void Main() //Metodo principal
    {
        Prueba saludos = new Prueba();
        Prueba resultados = new Prueba(); 
        saludos.saludo();
        Console.WriteLine($"El resulato de la suma es: {resultados.sumar()}");
        Console.WriteLine(saludos.despedir());
    }

}