using System;

class Persona
{
    private string nombre;
    private string apellido;
    private int edad;
    private double altura; 
    public Persona(string nombre, string apellido, int edad, double altura)
    {
        this.nombre=nombre;
        this.apellido=apellido;
        this.edad=edad;
        this.altura=altura;
    }

    public string NombreCompleto()
    {
        return nombre + " " + apellido;
    }

    public double AlturaMetros()
    {
        return altura / 100;
    }
    public void Datos()
    {
        Console.WriteLine("Nombre Completo: " + NombreCompleto());
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Altura (cm): " + altura);
        Console.WriteLine("Altura (mts): " + AlturaMetros());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apellido:");
        string apellido = Console.ReadLine();
        Console.WriteLine("Ingrese la edad:");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la altura en cm:");
        double altura = Convert.ToDouble(Console.ReadLine());

        Persona persona = new Persona(nombre, apellido, edad, altura);
        persona.Datos();
    }
}