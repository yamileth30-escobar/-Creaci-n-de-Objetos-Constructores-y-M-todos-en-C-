using System;

class Program
{
    static void Main(string[] args)
    {
        // LLAMADO DE MÉTODOS
        string nombre = SolicitarNombre();

        int n1 = SolicitarNumero("Ingresa el primer número: ");
        int n2 = SolicitarNumero("Ingresa el segundo número: ");

        int resultado = Sumar(n1, n2);

        Console.WriteLine("\nHola " + nombre);
        Console.WriteLine("El resultado de la suma es: " + resultado);

        Console.ReadKey();
    }

    // MÉTODO QUE RETORNA UN VALOR (Valida que solo sean letras)
    public static string SolicitarNombre()
    {
        string entrada;
        bool esValido = false;

        do
        {
            Console.Write("Ingresa tu nombre (solo letras): ");
            entrada = Console.ReadLine();

            esValido = !string.IsNullOrWhiteSpace(entrada);

            // Verifica que cada caracter sea una letra o espacio
            foreach (char c in entrada)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    esValido = false;
                    break;
                }
            }

            if (!esValido) Console.WriteLine("Error: El nombre no debe contener números ni estar vacío.");

        } while (!esValido);

        return entrada;
    }

    // MÉTODO QUE RETORNA UN VALOR (Valida que sea un número)
    public static int SolicitarNumero(string mensaje)
    {
        int numero;
        Console.Write(mensaje);

        // TryParse evita que el sistema dé error si se ingresan letras
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Error: Ingresa un número válido: ");
        }
        return numero;
    }

    // MÉTODO CON PARÁMETROS Y RETORNO
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
}
