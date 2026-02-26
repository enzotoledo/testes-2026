using static System.Console;
namespace Chamada
{
    class Program
    {
        public static void Main()
        {
            string[] nomes = new string[] { "enzo", "Marina", "douglas", "sol", "lucas", "pablo", "miriam"};
            int confirmarPresença = 0;
            int naoCompareceu = 0;
            
            while (true)
            {
                foreach (string nome in nomes)
                {
                    Console.WriteLine($"O aluno {nome} está presente? (s/n)");
                    string resposta = Console.ReadLine();
                    if (resposta.ToLower() == "s")
                    {
                        confirmarPresença++;
                    }
                    else if (resposta.ToLower() == "n")
                    {
                       naoCompareceu++;
                    }
                }
                break;
            }
            
            Console.WriteLine("gostaria de rever a lista de presença? (s/n)");
            string respostaRevista = Console.ReadLine();
            if (respostaRevista.ToLower() == "s")
            {
                Console.WriteLine("Lista de presença:");
                Console.WriteLine($"Presentes: {nomes.Length - naoCompareceu}");
                Console.WriteLine($"Ausentes: {nomes.Length - confirmarPresença}");
            }
            else if (respostaRevista.ToLower() == "n")
            {
                Console.WriteLine("gostria de saber a porcentagem de presença? (s/n)");
                string porcentagem = Console.ReadLine();
                if (porcentagem.ToLower() == "s")
                {
                    double total = confirmarPresença + naoCompareceu;
                    double porcentagemPresenca = (confirmarPresença / total) * 100;
                    Console.WriteLine($"Porcentagem de presença: {porcentagemPresenca:F2}%");
                }
                else if (porcentagem.ToLower() == "n")
                {
                    Console.WriteLine("Obrigado por usar o sistema de chamada!");
                }
            }
        }
    }
}

            
