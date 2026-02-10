using System.Runtime.InteropServices;

namespace habilidades
{
    class habilidades
    {      

        static void Main()
        {
            Console.WriteLine("olá usario qual é o seu nome?");
            string? nome = Console.ReadLine();
            while (true)
            {
            Console.WriteLine($"olá {nome}, quanto lado tem a forma que vc deseja saber");
            string? lados = Console.ReadLine();
            int ladosInt = int.Parse(lados);
            switch (ladosInt)
            {
                case 3:
                    Console.WriteLine("a forma é um triangulo");
                    break;
                case 4:
                    Console.WriteLine("tem lados do mesmo tamanho?");
                    string? resposta = Console.ReadLine();
                    if (resposta == "sim")
                        Console.WriteLine("a forma é um quadrado");
                    else
                        Console.WriteLine("a forma é um retângulo");
                    break;
                case 5:
                    Console.WriteLine("a forma é um pentágono");
                    break;
                case 6:
                    Console.WriteLine("a forma é um hexágono");
                    break;
                case 7:
                    Console.WriteLine("a forma é um heptágono");
                    break;
                case 8:
                    Console.WriteLine("a forma é um octógono");
                    break;
                case 9:
                    Console.WriteLine("a forma é um eneágono");
                    break;
                case 10:
                    Console.WriteLine("a forma é um decágono");
                    break;
                default:
                    Console.WriteLine("desculpe, não sei qual é a forma com esse número de lados");
                    break;
            }
            Console.WriteLine($"muito obrigado {nome} por ter usado o programa, espero ter ajudado!");
            Console.WriteLine("você deseja saber a forma de outro número de lados? (sim/não)");
            string? resposta2 = Console.ReadLine();
            if (resposta2 != "sim")
            {
                break;
            }
            }
        }
    }
}