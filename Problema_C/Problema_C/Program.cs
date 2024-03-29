using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
internal class Program
{
    private static void Main(string[] args)
    {
        //iniciando a variavel referente ao numero de testes
        int N = 0;
        //Dicionario referentes aos casos 
        Dictionary<int,string> frases = new Dictionary<int,string>();
        
        List<string> vogais = ["a", "á", "à", "e", "é", "è", "i"," í","ì","o","ó","ò","u","ú","ù"];

        void InicioPrograma()
        {
            Console.WriteLine("Inicio do Programa");
            Console.WriteLine("Informe o numero de casos de teste");
            Console.Write("R: ");
            N= int.Parse(Console.ReadLine());
            VerificaCasos(N);
            verificaVogaisEConsoantes();
        }


        InicioPrograma();

        

        void VerificaCasos(int numCasos) {

            for (int i = 1; i <= numCasos; i++)
            {

                Console.WriteLine("Informe os casos de teste");
                Console.Write("R: ");
                string palavra = Console.ReadLine();
                  
                string caso = palavra.ToLower().Replace(" ","");
                
                string[] letrasCasos = new string[caso.Length];
                int tamanhoCarac = letrasCasos.Length;
                if (tamanhoCarac <= 80 && tamanhoCarac > 0)
                {

                    for (int x = 0; x < letrasCasos.Length; x++)
                    {
                        letrasCasos[x] = caso[x].ToString();

                    }
                    string casoVerificado = "";
                    foreach (string l in letrasCasos)
                    {
                        foreach (char c in l) {

                            casoVerificado += c;

                            

                        }
                        

                    }
                    
                    frases.Add(i, casoVerificado);
                                        
                }
                else
                {
                    Console.WriteLine("O numero de caracteres foi execedido o limite");
                }



            }
            
        }
        void verificaVogaisEConsoantes()
        {
            foreach(KeyValuePair<int,string> x in frases) 
            {
                int numVogais = 0;
                int numConsoantes = 0;
                string[] palavras = new string[x.Value.Length];
                for (int i = 0; i < palavras.Length;i++) 
                {
                    palavras[i] = x.Value[i].ToString();
                
                }
                foreach (string c in palavras) {

                    if (c != "?" && c != "!" && c != ",")
                    {
                       

                        foreach (string j in vogais)
                        {
                            if (j == c)
                            {

                                numVogais += 1;
                            }
                            

                        }

                        if (!vogais.Contains(c))
                        {

                            numConsoantes += 1;
                        }

                    }

                    

                    
                     
                
                }

                Console.WriteLine( $"{numVogais} {numConsoantes}");
            }
            


        }





    }
}