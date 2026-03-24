namespace Fundamentos01;

public class OperadoresLogicos
{
    public void Executar()
    {
        bool temIdade = true;
        bool temCarta = false;

        Console.WriteLine("\nOPERADORES LOGICOS");
        Console.WriteLine($"Tem idade? {temIdade}");
        Console.WriteLine($"Tem Carta? {temCarta}");
        Console.WriteLine();
        Console.WriteLine($"Pode dirigir ? (tem Idade e Carta) -> {temIdade && temCarta} (AND)");
        Console.WriteLine($"Pode tentar tirar ? (tem Idade ou Carta) -> {temIdade || temCarta} (OR)");
        Console.WriteLine($"Não tem idade ? (!tem idade) -> {!temIdade} (NOT)");

    }
}