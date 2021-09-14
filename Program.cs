using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Clear();
            double cap;
            double juros;
            double tempo;

            Console.Write("Juros");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("Simples");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Digite o valor R$..........");
            cap= double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da taxa de juros%....");
            juros= double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da taxa de juros%.....");
             juros= double.Parse(Console.ReadLine());

             Console.Write("Digite o tempo em parcelas (meses)....");
             tempo= double.Parse(Console.ReadLine());
             Console.WriteLine();

             double juros1= juros/100;
             double jurosres = (cap* juros1* tempo);
             
             Console.WriteLine($"Juros(R$)......{jurosres}");
             double montante= (cap+jurosres);
             Console.WriteLine($"Montante (R$).....{montante}");
             Console.WriteLine();
             Console.ForegroundColor=ConsoleColor.DarkRed;
             Console.WriteLine("Pressione qualquer tecla para Finalizar....");
             Console.ResetColor();
             Console.ReadKey();






        


            
           }

    }

}   




