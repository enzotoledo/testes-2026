using System;
using System.Security.Cryptography;
class Program{
    public class concessionaria{
    static void Main()
    {   
     //CARROS SUVS
        string Land_Rover = 
        "motor:2.0 I4 potencia:250cv torque:36,3 kgfm tração:4X4 cambio:automatico 9 machas 0-100:7,6s velocidade maxima:230km/h combustivel:flex porta-malas:591 litros lugares:5 pessoas";
        string Tiguan = 
        "motor:2.0 TSI I4 potencia:186cv torque:30,6 kgfm tração:4X2 cambio:automatico 8 machas 0-100:6,8s velocidade maxima:215km/h combustivel:gasolina porta-malas:686 litros lugares:7 pessoas";
        string Sw4 = 
        "motor:2.8 I4 potencia:208cv torque:50,9 kgfm tração:4X4 cambio:automatico 6 machas 0-100:11,8s velocidade maxima:180km/h combustivel:diesel porta-malas:500 litros lugares:7 pessoas";
    //CARROS SEDANS
        string Audi_RS7 = 
        "motor:4.0 V8 potencia:600cv torque:81,6 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,6s velocidade maxima:280km/h combustivel:gasolina porta-malas:535 litros lugares:5 pessoas";
        string BMW_M3CS = 
        "motor:3.0 I6 potencia:550cv torque:66,3 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,4s velocidade maxima:302km/h combustivel:gasolina porta-malas:480 litros lugares:5 pessoas";
        string Mercedes_ClasseS = 
        "motor:4.0 V8 potencia:802cv torque:76,4 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,3s velocidade maxima:210km/h combustivel:gasolina porta-malas:550 litros lugares:5 pessoas";   
    //CARROS HATCH    
        string Mercedes_A45 =
        "motor:2.0 I4 potencia:421cv torque:51,0 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,9s velocidade maxima:270km/h combustivel:gasolina porta-malas:370 litros lugares:5 pessoas";
        string BMW_M135 = 
        "motor:2.0 I4 potencia:317cv torque:40,7 kgfm tração:4X4 cambio:automatico 7 machas 0-100:4,9s velocidade maxima:250km/h combustivel:gasolina porta-malas:380 litros lugares:5 pessoas";
        string Golf_GTI = 
        "motor:2.0 I4 TSI potencia:265cv torque:37,7 kgfm tração:FWD cambio:automatico 7 machas 0-100:5,9s velocidade maxima:250km/h combustivel:gasolina porta-malas:381 litros lugares:5 pessoas";
    Console.WriteLine("olá bem vindo à concessionaria SOLar"); 
    Console.WriteLine($"que carro você gostaria de ver?");  
          /*  while (true)
            {
                for(int count = 0;count < 5;count ++)
                { */
                    Console.WriteLine("1.SUV");
                    Console.WriteLine("1.SEDANS");
                    Console.WriteLine("3.HATCH");
                    Console.WriteLine("digite o número de qual vc deseja ver");
                    string? resposta = Console.ReadLine();
                   int resposta2 = Convert.ToInt32(resposta);
                    switch (resposta2)
                    {
                    case 1:
                        Console.WriteLine("em suv nós temos");
                        Console.WriteLine("1.Land Rover");
                        Console.WriteLine("2.Tiguan");
                        Console.WriteLine("3.SW4");
                        string? resposta3 = Console.ReadLine();
                        int resposta4 = Convert.ToInt32(resposta3);
                        if (resposta4 == 1)
                            {
                            Console.WriteLine($"{Land_Rover}");
                            }
                        else if (resposta4 == 2)
                            {
                            Console.WriteLine($"{Tiguan}");    
                            }
                        else if (resposta4 == 3)
                            {
                            Console.WriteLine($"{Sw4}");    
                            }
                            else
                            {
                            Console.WriteLine("infelizmente só temos esses");    
                            }
                        break;        
                        case 2: 
                        {
                        Console.WriteLine("em sedans nós temos");
                        Console.WriteLine("1.Audi RS7");
                        Console.WriteLine("2.BMW M3 CS");
                        Console.WriteLine("3.Mercedez Classe S");
                        string? resposta5 = Console.ReadLine();
                        int resposta6 = Convert.ToInt32(resposta5);
                        if (resposta6 == 1)
                            {
                            Console.WriteLine($"{Audi_RS7}");
                            }
                        else if (resposta6 == 2)
                            {
                        Console.WriteLine($"{BMW_M3CS}");    
                            }
                        else if (resposta6 == 3)
                            {
                            Console.WriteLine($"{Mercedes_ClasseS}");    
                            }
                        else
                            {
                            Console.WriteLine("infelizmente só temos esses");    
                            }   
                        }
                        break;
                        case 3:
                        {
                        Console.WriteLine("em hatch nós temos");
                        Console.WriteLine("1.Mercedez A45");
                        Console.WriteLine("2.BMW M135");
                        Console.WriteLine("3.Golf GTI");
                        string? resposta7 = Console.ReadLine();
                        int resposta8 = Convert.ToInt32(resposta7);
                        if (resposta8 == 1)
                            {
                            Console.WriteLine($"{Mercedes_A45}");
                            }
                        else if (resposta8 == 2)
                            {
                        Console.WriteLine($"{BMW_M135}");    
                            }
                        else if (resposta8 == 3)
                            {
                            Console.WriteLine($"{Golf_GTI}");    
                            }
                        else
                            {
                            Console.WriteLine("infelizmente só temos esses");    
                            }   
                        
                        break;
                        }    
                    }
                    Console.WriteLine("você gostaria de fazer um comparativo? (sim/não)");
                  string? resposta9 = Console.ReadLine();
                    if (resposta9.ToLower() == "sim")
                    {
                    Console.WriteLine("digite o numero do carro 1 vc gostaria de comparar?");
                        Console.WriteLine("1 Land Rover");
                        Console.WriteLine("2 Tiguan");
                        Console.WriteLine("3 Sw4");
                        Console.WriteLine("4 Audi RS7");
                        Console.WriteLine("5 BMW M3 CS");
                        Console.WriteLine("6 mercedes ClasseS");
                        Console.WriteLine("7 Mercedes A45");
                        Console.WriteLine("8 BMW M135");
                        Console.WriteLine("9 Golf GTI");
                    string? R2 = Console.ReadLine();
                    double R4 = Convert.ToInt32(R2);
                    Console.WriteLine("digite o numero do carro 2 vc gostaria de comparar?");
                        Console.WriteLine("1 Land Rover");
                        Console.WriteLine("2 Tiguan");
                        Console.WriteLine("3 Sw4");
                        Console.WriteLine("4 Audi RS7");
                        Console.WriteLine("5 BMW M3 CS");
                        Console.WriteLine("6 mercedes ClasseS");
                        Console.WriteLine("7 Mercedes A45");
                        Console.WriteLine("8 BMW M135");
                        Console.WriteLine("9 Golf GTI");                         
                    string? R3 = Console.ReadLine();
                    double R5 = Convert.ToInt32(R3);
                        switch (R4)
                        {
                            case 1:Console.WriteLine($"{Land_Rover}");break;
                            case 2:Console.WriteLine($"{Tiguan}");break;
                            case 3:Console.WriteLine($"{Sw4}");break;
                            case 4:Console.WriteLine($"{Audi_RS7}");break;
                            case 5:Console.WriteLine($"{BMW_M3CS}");break;
                            case 6:Console.WriteLine($"{Mercedes_ClasseS}");break;
                            case 7:Console.WriteLine($"{Mercedes_A45}");break;
                            case 8:Console.WriteLine($"{BMW_M135}");break;
                            case 9:Console.WriteLine($"{Golf_GTI}");break;
                            default: Console.WriteLine("não existe");
                            break;
                        }
                        switch (R5)
                        {
                            case 1:Console.WriteLine($"{Land_Rover}");break;
                            case 2:Console.WriteLine($"{Tiguan}");break;
                            case 3:Console.WriteLine($"{Sw4}");break;
                            case 4:Console.WriteLine($"{Audi_RS7}");break;
                            case 5:Console.WriteLine($"{BMW_M3CS}");break;
                            case 6:Console.WriteLine($"{Mercedes_ClasseS}");break;
                            case 7:Console.WriteLine($"{Mercedes_A45}");break;
                            case 8:Console.WriteLine($"{BMW_M135}");break;
                            case 9:Console.WriteLine($"{Golf_GTI}");break;
                            default: Console.WriteLine("não existe");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("muito obrigado por visitar o site");
                    }
                }
            }
        }             
 /* }    
}*/
    
