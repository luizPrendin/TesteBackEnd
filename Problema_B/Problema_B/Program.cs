using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, int> AlturasMin = new();
        //Variavel referente a altura do jovem
        int H = 0;
        //Variavel referente ao numero de brinquedos 
        int N = 0;
        //Variavel referente a altura minima do brinquedo
        int A = 0;


        inicioPrograma();

        if (N == 1)
        {

            AlturasMin.Add(N, A);
            if (H >= A)
            {
                Console.WriteLine("A quantidade de brinquedos que o jovem ira é:");
                Console.WriteLine(N);
                Thread.Sleep(4000);
                Console.Clear();
                inicioPrograma();
            }
            else
            {
                Console.WriteLine("A quantidade de brinquedos que o jovem ira é: 0");
                Thread.Sleep(4000);
                Console.Clear();
                inicioPrograma();
            }
        }

        if (N > 1 && N < 6 && H > 90 && H < 200)
        {
            
            for (int x = 1; x <= N;)
            {
                entrada2();
                AlturasMin.Add(x, A);
                x++;
            }
            if (A > 90 && A < 200)
            {
                int temp = 0;
                foreach (var i in AlturasMin)
                {

                    if (H >= i.Value)
                    {
                        temp += 1;

                    }

                }
                Console.WriteLine("A quantidade de brinquedos que o jovem ira é:");
                Console.WriteLine(temp);
                Thread.Sleep(4000);
                Console.Clear();
                inicioPrograma();


            }
            else
            {
                Console.WriteLine("Por favor insira valores dentro das especificações");
                entrada2();
            }
        }
        else
        {
            Console.WriteLine("Por favor insira valores dentro das especificações");
            entrada1();
        }



        void inicioPrograma()
        {
            entrada1();
            
        }

        void entrada1()
        {
            Console.WriteLine("Inicio do programa");
            Console.WriteLine("Informe o numero de brinquedos: ");
            Console.Write("R: ");
            string entradaNumBrinquedo = Console.ReadLine();
            N = int.Parse(entradaNumBrinquedo);
            Console.WriteLine("Informe sua  altura em cm: ");
            Console.Write("R: ");
            string entradaAltura = Console.ReadLine();
            H = int.Parse(entradaAltura);

        }
        void entrada2()
        {

            Console.WriteLine("Informe a altura minima do brinquedo em cm: ");
            Console.Write("R: ");
            string entradaAlturaMin = Console.ReadLine();
            A = int.Parse(entradaAlturaMin);
            
        }
    }
}