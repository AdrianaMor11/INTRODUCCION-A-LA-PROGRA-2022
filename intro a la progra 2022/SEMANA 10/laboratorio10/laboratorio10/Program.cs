
int contador = 1;
string usuario = "";
string pass = "";

while(contador <= 3)
{
    Console.WriteLine("Ingrese Usuario");
    usuario = Console.ReadLine().ToString();
    Console.WriteLine("Ingrese Contraseña");
    pass = Console.ReadLine().ToString();

    if(usuario.Equals("usuario1") && pass.Equals("asdasd"))
    {
        Console.WriteLine("Verdadero");
        break;
    }
    else
    {
        contador++;
    }
}

if(contador == 3)
{
    Console.WriteLine("Cantidad de intentos permitidos superado");
}