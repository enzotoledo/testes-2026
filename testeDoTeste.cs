using System.Runtime.InteropServices;

namespace testeDoTeste
{
    class testeDoTeste
    {
        static void Main()
        {
            Console.WriteLine("olá usuário qual é o seu nome?");
            string? nome = Console.ReadLine();
            Console.WriteLine($"olá {nome} seja bem vindo ao programa de formas geométricas");
                while (true)
                {
                    Console.WriteLine("Quantos lados tem a forma geométrica que você quer saber?");
                    int lados = int.Parse(Console.ReadLine()!);
                    string forma = lados 
                    switch
                    {
                        3 => "Triângulo",
                        4 => ObterNomeFormaQuadrilateral(),
                        5 => "Pentágono",
                        6 => "Hexágono",
                        7 => "Heptágono",
                        8 => "Octógono",
                        9 => "Eneágono",
                        10 => "Decágono",
                        _ => EssaFormaExiste(),
                    };
                    Console.WriteLine($"{nome}, a forma com {lados} lados é: {forma}");
                    Console.WriteLine("Deseja saber sobre outra forma? (sim/não)");
                    string? respostaOutraForma = Console.ReadLine();
                    if (respostaOutraForma?.ToLower() != "sim")
                    {
                        break;
                    }
                }
            }
    
            static string ObterNomeFormaQuadrilateral()
            {
                Console.WriteLine("os lados são iguais?");
                string? resposta = Console.ReadLine();
                return resposta == "sim" ? "Quadrado" : "Retângulo";
        }
            static string EssaFormaExiste()
            {
                Console.WriteLine("você tem certeza que essa forma existe?");
                string? resposta = Console.ReadLine();
               if (resposta == "sim")
                    return("perdão, não sei qual é a forma com esse número de lados");
                else
                    return("você é burro?");
            }
    }
}