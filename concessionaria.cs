using System;
public class concessionaria{        
        string [] suv = {Land_Rover,Tiguan,Sw4};
            string Land_Rover = 
            "motor:2.0 I4 potencia:250cv torque:36,3 kgfm tração:4X4 cambio:automatico 9 machas 0-100:7,6s velocidade maxima:230km/h combustivel:flex porta-malas:591 litros lugares:5 pessoas";
            string Tiguan = 
            "motor:2.0 TSI I4 potencia:186cv torque:30,6 kgfm tração:4X2 cambio:automatico 8 machas 0-100:6,8s velocidade maxima:215km/h combustivel:gasolina porta-malas:686 litros lugares:7 pessoas";
            string Sw4 = 
            "motor:2.8 I4 potencia:208cv torque:50,9 kgfm tração:4X4 cambio:automatico 6 machas 0-100:11,8s velocidade maxima:180km/h combustivel:diesel porta-malas:500 litros lugares:7 pessoas";
        string [] sedan = {Audi_RS7,BMW_M3CS,Mercedes_ClasseS};
            string Audi_RS7 = 
            "motor:4.0 V8 potencia:600cv torque:81,6 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,6s velocidade maxima:280km/h combustivel:gasolina porta-malas:535 litros lugares:5 pessoas";
            string BMW_M3CS = 
            "motor:3.0 I6 potencia:550cv torque:66,3 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,4s velocidade maxima:302km/h combustivel:gasolina porta-malas:480 litros lugares:5 pessoas";
            string Mercedes_ClasseS = 
            "motor:4.0 V8 potencia:802cv torque:76,4 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,3s velocidade maxima:210km/h combustivel:gasolina porta-malas:550 litros lugares:5 pessoas";
        string [] hatch = {Mercedes_A45,BMW_S1,Golf_GTI};  
            string Mercedes_A45 =
            "motor:2.0 I4 potencia:421cv torque:51,0 kgfm tração:4X4 cambio:automatico 8 machas 0-100:3,9s velocidade maxima:270km/h combustivel:gasolina porta-malas:370 litros lugares:5 pessoas";
            string BMW_M135 = 
            "motor:2.0 I4 potencia:317cv torque:40,7 kgfm tração:4X4 cambio:automatico 7 machas 0-100:4,9s velocidade maxima:250km/h combustivel:gasolina porta-malas:380 litros lugares:5 pessoas";
            string Golf_GTI = 
            "motor:2.0 I4 TSI potencia:265cv torque:37,7 kgfm tração:FWD cambio:automatico 7 machas 0-100:5,9s velocidade maxima:250km/h combustivel:gasolina porta-malas:381 litros lugares:5 pessoas";
    static void main()
    {
    Console.WriteLine("olá bem vindo à concessionaria SOLar");
        while (true)
        {
            foreach(string carro in carros)
            {
                Console.WriteLine($"que carro você gostaria de ver?{carro}");
                string? resposta = Console.ReadLine();
                if (resposta == suv)
                {
                Console.WriteLine("suv nós temos uma land rover, tiguan e uma toyot sw4 qual você gostaria de ver?");
                string? resposta2 = Console.ReadLine();
                    if(resposta2 == Land_Rover)
                    {
                        Console.WriteLine($"{Land_Rover}");
                    }
                    else if (resposta2 == Tiguan)
                    {
                        Console.WriteLine($"{Tiguan}");
                    }
                    else if (resposta2 == Sw4)
                    {
                        Console.WriteLine($"{Sw4}");   
                    }

                }
                else if(resposta == sedan)
                {
                Console.WriteLine("Sedans nós temos audi rs7, bmw m3 cs e uma mercedes classe S qual você gostaria de ver?");
                string? resposta3 = Console.ReadLine();
                    if(resposta3 == Audi_RS7)
                    {
                        Console.WriteLine($"{Audi_RS7}");
                    }
                    else if (resposta3 == BMW_M3CS)
                    {
                        Console.WriteLine($"{BMW_M3CS}");
                    }
                    else if (resposta3 == Mercedes_ClasseS)
                    {
                        Console.WriteLine($"{Mercedes_ClasseS}");   
                    } 
                }
                else if(resposta == hatch)
                Console.WriteLine("hatch nós temos mercedes A45, BMW M135 e Golf GTI qual você gostaria de ver?");
                string? resposta4 = Console.ReadLine();
                    if(resposta4 == Mercedes_A45)
                    {
                        Console.WriteLine($"{Mercedes_A45}");
                    }
                    else if (resposta4 == BMW_M135)
                    {
                        Console.WriteLine($"{BMW_M135}");
                    }
                    else if (resposta4 == Golf_GTI)
                    {
                        Console.WriteLine($"{Golf_GTI}");   
                    }
                Console.WriteLine("Hatch nós temos uma mercedes A45, BMW M135 e um Golf GTI qual você gostaria de ver?");
                }
            }
        }    
    }
