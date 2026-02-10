using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("qual a quantidade de poligonos?");
        string? poligonos = Console.ReadLine();
        int poligonosInt = Convert.ToInt32(poligonos);
        switch (poligonosInt){
            case 3:
                Console.WriteLine("triangulo");
                break;
            case 4:
                Console.WriteLine("são do mesmo tamanho?");
                string? resposta = Console.ReadLine();
            if (resposta == "sim")
                Console.WriteLine("quadrado");
            else
                Console.WriteLine("retangulo");
                break;
            case 5:
                Console.WriteLine("pentagono");
                break;
            case 6:
                Console.WriteLine("hexagono");
                break;
            case 7:
                Console.WriteLine("heptagono");
                break;
            case 8:
                Console.WriteLine("octagono");
                break;    
            default:
                Console.WriteLine("não é um poligono conhecido");
                break;
        }    
        switch (poligonosInt){
            case >=1 and <=2:
                Console.WriteLine("básico");    
                break;    
            case >=3 and <=4:
                Console.WriteLine("intermediario");    
                break;    
            case >=5 and <=6:
                Console.WriteLine("avançado");
                break;    
            default:
                Console.WriteLine("não é um poligono conhecido");
            break;
        }
        
    }
}