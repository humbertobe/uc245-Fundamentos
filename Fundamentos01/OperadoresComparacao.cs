namespace Fundamentos01;

public class OperadoresComparacao
{
    public void Executar()
    {
        int x = 5;
        int y = 8;

        Console.WriteLine("\nOPERADOR COMPARAÇÃO");
        Console.WriteLine($"x = {x}, y = {y}");
        Console.WriteLine($"x == y -> {x == y} // Igualdade: false ");
        Console.WriteLine($"x != y -> {x != y} // Diferença: true");
        Console.WriteLine($"x > y -> {x > y}// Maior que: false");
        Console.WriteLine($"x < y -> {x < y}// Menor que: true");
        Console.WriteLine($"x >= 5 -> {x >= 5}// Maior ou igual: true");
        Console.WriteLine($"y <= 10 -> {y <= 10}// Menor ou igual: true");
    }
}