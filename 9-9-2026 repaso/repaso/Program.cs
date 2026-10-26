string contraseña = "ThiagoPete12";

Console.WriteLine("que onda, porfavor introduce tu contraseña");

string entrada = Console.ReadLine() ?? "";

if (string.IsNullOrWhiteSpace(entrada))
{
  Console.WriteLine("no podes dejarlo vacio, che!");
}
else if (int.TryParse(entrada, out _))
{
  Console.WriteLine("solo letras pa");
}
else if(entrada == contraseña)
{
  Console.WriteLine("contraseña correcta");
}
else
{
  Console.WriteLine("incorrecto! raja de aca");
}