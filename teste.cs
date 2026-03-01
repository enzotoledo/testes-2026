using System;

class Program
{
    public class teste
    {
     string Land_Rover = 
    "motor:2.0 I4 potencia:250cv torque:36,3 kgfm tração:4X4 cambio:automatico 9 machas 0-100:7,6s velocidade maxima:230km/h combustivel:flex porta-malas:591 litros lugares:5 pessoas";
    string Tiguan = 
    "motor:2.0 TSI I4 potencia:186cv torque:30,6 kgfm tração:4X2 cambio:automatico 8 machas 0-100:6,8s velocidade maxima:215km/h combustivel:gasolina porta-malas:686 litros lugares:7 pessoas";
    string Sw4 = 
    "motor:2.8 I4 potencia:208cv torque:50,9 kgfm tração:4X4 cambio:automatico 6 machas 0-100:11,8s velocidade maxima:180km/h combustivel:diesel porta-malas:500 litros lugares:7 pessoas";   
   
        static void Main()
        {
        string Land_Rover = 
        "a land rover possui as seguintes caracteristicas motor:2.0 I4 potencia:250cv torque:36,3 kgfm tração:4X4 cambio:automatico 9 machas 0-100:7,6s velocidade maxima:230km/h combustivel:flex porta-malas:591 litros lugares:5 pessoas";
        string Tiguan = 
        "a tiguan possui as seguintes caracteristicas motor:2.0 TSI I4 potencia:186cv torque:30,6 kgfm tração:4X2 cambio:automatico 8 machas 0-100:6,8s velocidade maxima:215km/h combustivel:gasolina porta-malas:686 litros lugares:7 pessoas";
        string Sw4 = 
        "a sw4 possui as seguintes caracteristicas motor:2.8 I4 potencia:208cv torque:50,9 kgfm tração:4X4 cambio:automatico 6 machas 0-100:11,8s velocidade maxima:180km/h combustivel:diesel porta-malas:500 litros lugares:7 pessoas";   
            Console.WriteLine("olá bem vindo à concessionaria SOLar, qual carro vc gostaria de ver? 1.land rover 2.tiguan 3.sw4");
            string? resposta = Console.ReadLine();
            int resposta2 = Convert.ToInt32(resposta);
            switch (resposta2)
            {
            case 1:
                Console.WriteLine($"{Land_Rover}");
                break;
            case 2:
                Console.WriteLine($"{Tiguan}");
                break;
            case 3:
                Console.WriteLine($"{Sw4}");
                break;
            default:
                Console.WriteLine("só temos esses");
                break;
            }
            
        }
    }
 }