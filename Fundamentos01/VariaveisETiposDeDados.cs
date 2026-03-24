namespace Fundamentos01;

public class VariaveisETiposDeDados
{
    string sobreNome = "José";
    public void Executar()
    {
        Console.WriteLine("VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("Variáveis são espaços na memória para guardar informações.");
        Console.WriteLine();

        int idade = 25;
        double altura = 1.75;
        float media = 195;
        char letra = 'A';
        string nome = "Humberto";
        string nomeComposto = nome + " Santos"; // + é concatenação
        bool estudante = true;
        
        Console.WriteLine($"int -> idade : {idade} (numero inteiros)");
        Console.WriteLine($"double -> altura : {altura} (numeros decimais)");
        Console.WriteLine($"char -> letra : {letra} (um unico caractere)");
        Console.WriteLine($"string -> nome : {nomeComposto} (texto)");
        Console.WriteLine($"variavel global -> sobrenome : {this.sobreNome} (variavel global)");
        Console.WriteLine($"bool -> estudante : {estudante} (booleano, verdadeiro ou falso)");

    }


}//fim de classe