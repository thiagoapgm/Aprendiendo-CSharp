class Precios
{
    public double precio;

    public string producto;


    public Precios (double precio, string producto)
    {
        this.precio = precio;
        this.producto = producto;
    }

    public void MostrarPrecio()
    {
        Console.WriteLine("El precio es: " + precio);
        Console.WriteLine("El producto es: " + producto);
    }

}


class Informacion
{
    static void Main(string[] args)
    {
        Precios precio1 = new Precios(100.50, "chicle");
        precio1.MostrarPrecio();
    }
}