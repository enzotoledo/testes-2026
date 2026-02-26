using System;
class Program;
public class chamada
{

    static void Main() 
    { 
    string [] nomes= {"enzo","marina","douglas","sol","serena","lucas","pablo","miriam","bex","mirinha"};
    int compareceu = 0;
    int naoCompareceu = 0;
        while(true)
        {
            foreach (string nome in nomes)
            {
                Console.WriteLine($"o aluno {nome} está presente?(s/n)");
                string? presente = Console.ReadLine();
                if(presente == "s")
                    {
                        compareceu++;
                    }
                    else
                    {
                        naoCompareceu++;
                }
            }
            break;
        }
        Console.WriteLine($"presentes {compareceu}");
        Console.WriteLine($"ausentes {naoCompareceu}");
        double total = compareceu+naoCompareceu;
        double porcentagem = (compareceu / total) * 100;
        Console.WriteLine($"{porcentagem}%");
    }
}