
{
    static void Main(string[] args)
    {


        Console.WriteLine("Bienvenidos a nuestro primer sistema creado en C#");



        Console.WriteLine("Ingresa tu nombre para continuar");
        string Nombre = Consola.ReadLine();
        Console.WriteLine("Ingrese si edad");
        int Edad = Convert.ToInt32(Console.ReadLine());
        double EdadMeses = Edad * 12;
        Console.WriteLine(Nombre + "Tu edad em Meses es: " + EdadMeses + "Meses");
    }

