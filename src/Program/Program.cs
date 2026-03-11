public static class Program
{
    public class Multiplication
    {
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    }
    public static void Main()
    {
        Console.WriteLine(Suma.Sumar(1, 2));
        Console.WriteLine(Resta.Restar(3, 4));
        Console.WriteLine(Multiplicacion.Multiplicar(5, 6));
        Console.WriteLine(Division.Dividir(7, 8));
    }
}
