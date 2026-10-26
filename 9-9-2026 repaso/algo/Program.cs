Console.WriteLine(@"Hola, escribe algo que tenga menos de 12 caracteres

no te hagas el piola...
");
string? texto = Console.ReadLine();
bool? eso = false;
if(texto.Length >= 12)
{
    Console.WriteLine("NO PA´" );
    eso = true;
    while(eso == true)
    {
        Console.WriteLine("nose puede poner mas de 12 caracteres");
        texto = Console.ReadLine(); 

        if(texto.Length  <= 12)
        {
            Console.WriteLine("seguimos pa");
            eso = true;            
            break;
        }
    }
}
Console.WriteLine("La cantidad de caracteres son: " + texto.Length);
