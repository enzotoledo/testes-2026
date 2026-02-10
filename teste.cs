using System;

class Program
{
    static void Main()
    {
        string continuar = "sim";

        while (continuar.ToLower() == "sim")
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Quantos lados tem a forma? ");
            int lados = int.Parse(Console.ReadLine());

            string forma = ObterNomeForma(lados);
            Console.WriteLine($"{nome}, a forma com {lados} lados é: {forma}\n");

            Console.Write("Deseja saber sobre outra forma? (sim/não) ");
            continuar = Console.ReadLine();
        }

        Console.WriteLine("Obrigado por usar nosso programa!");
    }

    static string ObterNomeForma(int lados)
    {
        return lados switch
        {
            3 => "Triângulo",
            4 => "Quadrilátero",
            5 => "Pentágono",
            6 => "Hexágono",
            7 => "Heptágono",
            8 => "Octógono",
            _ => "Forma desconhecida"
        };
    }
}