namespace Problema_E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> numero = new Dictionary<int,string>();

            void iniciaPrograma()
            {

                Console.WriteLine("Inicio do programa");
                Console.WriteLine("Informe o andar:");
                Console.Write("R: ");
                int andar = int.Parse(Console.ReadLine());
                verificaAndar(andar);
            }
            iniciaPrograma();


            void verificaAndar(int andar)
            {

                if (andar > 0 && andar <=1018)
                {
                    string n= andar.ToString();
                    //string[] digitos = new string[n.Length];
                    for (int x = 0; x <n.Length; x++)
                    {
                        //digitos[x] = n[x].ToString();
                        numero.Add(x,n[x].ToString());
                    }
                    string andarDeterminado = "";
                    string[] digitos = new string[n.Length];
                    int indiceNumeroAtual = 0;
                    int indiceNumeroAnt = 1;
                    foreach (KeyValuePair<int,string> digit in numero) {
                        
                        if (digit.Value == "4")
                        {
                            digitos[indiceNumeroAtual] = "5";
                            andarDeterminado += digitos[indiceNumeroAtual];
                        }
                        else if (digit.Value =="3")
                        {
                            if (andarDeterminado == "1")
                            {
                                
                                andarDeterminado += "5";

                            }

                            
                        }
                        else
                        {
                            andarDeterminado += digit.Value;
                                                  
                        }

                        indiceNumeroAtual += 1;
                        indiceNumeroAnt -= indiceNumeroAtual;
                    }
                    Console.WriteLine(andarDeterminado);



                }




            }


        }
    }
}
