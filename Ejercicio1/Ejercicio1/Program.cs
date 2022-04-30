using logica;
internal class Program
{
    public static void Main(string[] args)
    {
        Logger Impresion=new Logger();
        Persona e = new Persona();
        CalculoLetras calculo=new CalculoLetras();
        e.NombreModificado += ActualizacionRealizadaHandler;
        e.ModificarNombre("Matias", "Alejandro");
        Impresion.NombreModificado += ActualizacionRealizadaHandler;
        calculo.NombreModificado = ActualizacionRealizadaHandler;

    }
    static void ActualizacionRealizadaHandler(object? sender, ActualizacionEventArgs e)
    {
        Console.WriteLine("Finalizaron todas las operaciones necesarias, el nombre nuevo es" + e.NombreNuevo, "y las letras diferentes son" + e.TotalLetrasDiferentes);
    }

    
    
}
