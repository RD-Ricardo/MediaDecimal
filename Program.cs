using System;
namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            double posicaoMenor = 0;
            double menor=0;
            double somador = 0;
            Console.WriteLine("-----------------");
            Console.WriteLine("--Media Decimal--");
            Console.WriteLine("-----------------\n");
            Console.WriteLine("Quantos números...: ");
            int c = Convert.ToInt32(Console.ReadLine());
            double[] Numeros = new double[c];
          
            for(int i = 0; i < Numeros.Length ; i++)
            {
                double num; 
                Console.Write($"Número #0{i + 1} :");
                num = Convert.ToDouble(Console.ReadLine());
                if(Numeros[i] <= menor)
                {
                    menor = num;
                    posicaoMenor = num;
                }
                somador += num; 
                Numeros[i] = num;
               
            }
            Console.WriteLine(somador);
            double media = somador / 4;
            Console.WriteLine(media);
            Console.WriteLine(c);
            Console.WriteLine(menor);
           
           
        }
    }
}
