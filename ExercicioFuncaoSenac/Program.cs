using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Primeiro número: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        int y = int.Parse(Console.ReadLine());

        int resultado = Soma(x, y);
        Console.WriteLine("Soma ={0}", resultado);

    }
    static int Soma(int n1, int n2)
    {
        int s = n1 + n2;
        return s;
    }
}