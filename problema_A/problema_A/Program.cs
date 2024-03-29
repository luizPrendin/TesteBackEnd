namespace problema_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            initPrograma();

            void initPrograma()
            {
                Console.WriteLine("Inicio do programa");
                Console.WriteLine("Informe a lagura do tabuleiro:");
                Console.Write("R: ");
                int largura = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o comprimento do tabuleiro:");
                Console.Write("R: ");
                int comprimento = int.Parse(Console.ReadLine());
                verificaQtdReisPossiveis(largura, comprimento);
            }

            void verificaQtdReisPossiveis(int largura,int comprimento)
            {
                string[,] tabuleiro = new string[comprimento,largura];

                if (largura>0 && comprimento > 0)
                {
                    /*acada impar em uma direçao é um rei add e 
                    quando é mais um impar nas duas direções são dois reis add                    
                     */
                    int resul = 0;
                    for (int i = 0; i < comprimento; i++) { 
                        for (int x = 0; x < largura; x++)
                        {
                            if(i % 2 == 0 && x % 2 == 0)
                            {
                                resul += 1;
                            }

                        }

                         
                            
                    }
                    Console.WriteLine(resul);
                    
                }


            }

        }
    }
}
