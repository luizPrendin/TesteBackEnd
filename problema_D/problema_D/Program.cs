namespace problema_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //iniciando variavel correspondente ao numero de participantes
           int N = 0;
           List<int> participantesLargada = new List<int>();
           List<int> participantesChegada = new List<int>();

            void IniciarPrograma()
            {
                Console.WriteLine("Inicio do Programa");
                Console.WriteLine("Informe quantos competidores irão participar");
                Console.Write("R: ");
                N = int.Parse(Console.ReadLine());
                addParticipantes(N);
                Console.WriteLine(verificaTrocas());

            }

            IniciarPrograma();


            void addParticipantes(int qtdCompetidores)
            {
                if (qtdCompetidores > 0 && qtdCompetidores <= 36)
                {

                    for (int i = 0; i < qtdCompetidores; i++)
                    {
                        Console.WriteLine("Informe o numero do participante em ordem de largada:");
                        Console.Write("R: ");
                        int numParticipanteL = int.Parse(Console.ReadLine());
                        participantesLargada.Add(numParticipanteL);

                    }
                    for (int x = 0; x < qtdCompetidores; x++)
                    {

                        Console.WriteLine("Informe o numero do participante em ordem de chegada:");
                        Console.Write("R: ");
                        int numParticipanteC = int.Parse(Console.ReadLine());
                        participantesChegada.Add(numParticipanteC);

                    }
                }
            }

            int verificaTrocas() {

                Dictionary<int ,int> mapChegada = new Dictionary<int ,int>();   
                int numtrocas = 0;
                int tamanhoListChegada = participantesLargada.ToArray().Length;
                for (int m = 0; m< tamanhoListChegada;m++)
                {
                    mapChegada[participantesChegada[m]] =m;

                }
                int tamanhoListLargada = participantesLargada.ToArray().Length;

                for (int z =0;z < tamanhoListLargada;z++ )
                {
                    Console.WriteLine($"Loop {z}");
                    Console.WriteLine(participantesLargada[z]);
                    Console.WriteLine(participantesChegada[z]);
                    if (participantesLargada[z] != participantesChegada[z])
                    {
                        int posiacaoCorreta = mapChegada[participantesLargada[z]];

                        int posicaoTemporaria = participantesChegada[z];
                        participantesChegada[z] = participantesChegada[posiacaoCorreta];
                        participantesChegada[posiacaoCorreta] = posicaoTemporaria;

                        numtrocas += 1;
                    }


                }

                return numtrocas;
            
            
            }






        }
    }
}
