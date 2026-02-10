namespace whatsYourNameApp
{
    class Program
    {
        static void Main()
        {
           //const string name = "enzo";
           Console.WriteLine("qual é o seu nome?");
           string? name = Console.ReadLine();
            if  (name == "dogras")
            Console.WriteLine("você é o dogras");
           else
           Console.WriteLine("eu sou o dogras você não é o dogras"); 
        }
    }
}
