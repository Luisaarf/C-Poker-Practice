//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

//Classe para mostrar dados na tela, interface do jogo
//todos os métodos são declarados estáticos assim podem ser invocados sem criar objetos do tipo da classe
// Ex:   Classe.métododaclasse()        não estático ex: Objeto.métododaclasse()

namespace JogoPoker
{
public class Show
    {
        //Pede para o jogador se ele quer rodar o teste ou o jogos
        public static void show_menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 - Teste");
            Console.WriteLine("2 - Jogo");
            Console.WriteLine("---------------------------------------------------");
        }

        //Pede para o jogador se ele quer recomeçar ou sair
        public static void show_restart()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");            
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Recomeçar\n2 - Sair\n");
            Console.WriteLine("---------------------------------------------------");

        }

        //Apresenta a lista de cartas
        public static void show_cards (List<Carta> cards)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Uma lista de cartas");
            Console.WriteLine("---------------------------------------------------");
            
            foreach (var item in cards)
            {
                string tmp = item.ToString(); //transforma as cartas em string
                Console.WriteLine(tmp);                
            }
            
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey();
        }

        public static void show_histogram(List<List<Carta>> histo)
        {
        	int ctrl = 0;

            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Uma lista de cartas");
            Console.WriteLine("---------------------------------------------------");
        	foreach(var list in histo)
        	{
        		if (list.Count == 0)
        			Console.WriteLine($"Cartas no índice: {ctrl} - 0");
        		else
                {
                    Console.WriteLine($"Cartas no índice: {ctrl}");		
        			for (int i = 0 ; i < list.Count ; i++)        			
        				Console.WriteLine("\t" + list[i].ToString());
                }
        		ctrl++;
        	}
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey(); 
            Console.Clear();

        } 

        public static void show_histojogo(List<List<Carta>> histo1 , List<List<Carta>> histo2 )
        {
            int ctrl = 0;
            Console.Clear();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Histograma do jogador 1");
            Console.WriteLine("---------------------------------------------------");

        	foreach(var list in histo1)
        	{
        		if (list.Count == 0)
        			Console.WriteLine($"Cartas no índice: {ctrl} - 0");
        		else
                {
                    Console.WriteLine($"Cartas no índice: {ctrl}");		
        			for (int i = 0 ; i < list.Count ; i++)        			
        				Console.WriteLine("\t" + list[i].ToString());
                }
        		ctrl++;
        	}
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla");
            Console.ReadKey();
            Console.Clear();

            int ctrl2 = 0;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Histograma do jogador 2");
            Console.WriteLine("---------------------------------------------------");
            //DrawCards.show_histogram(histo2.get_histogram());
            
            foreach(var list in histo2)
        	{
        		if (list.Count == 0)
        			Console.WriteLine($"Cartas no índice: {ctrl2} - 0");
        		else
                {
                    Console.WriteLine($"Cartas no índice: {ctrl2}");		
        			for (int i = 0 ; i < list.Count ; i++)        			
        				Console.WriteLine("\t" + list[i].ToString());
                }
        		ctrl2++;
        	}
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla");
            Console.ReadKey();
            Console.Clear();

        }

        public static void show_rank(string result)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Ranking da mão:");
            Console.WriteLine("---------------------------------------------------");
        	Console.WriteLine(result);
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey();
        }  

        public static void show_rankjogo(string result, string jogador, int valcarta)
        {

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Ranking da mão do {0}:", jogador);
            Console.WriteLine("---------------------------------------------------");
        	Console.WriteLine(result);
            if (result == "Carta mais Alta")
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("O valor dessa carta é: "+ valcarta);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey();
        } 

        public static void show_cartaalta(int valcarta)
        {
            if (valcarta > 0)
            {
                Console.WriteLine("O valor da carta mais alta é:");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(valcarta);
                Console.WriteLine("---------------------------------------------------");
                Console.ReadKey();
            }
            else
            {

            }
          
        }  

        public static void showJogo (Croupier c, Pessoa p1, Pessoa p2)
        {

            Console.Clear();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("JOGO");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("P1 Nome: " + p1.get_name());
            foreach (var carta in p1.get_mao())
            {
                Console.WriteLine(carta.ToString());
            }
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Cartas da mesa: " );
            foreach (var carta in c.get_mesa())
            {
                Console.WriteLine(carta.ToString());
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("P2 Nome: " + p2.get_name());
            foreach (var carta in p2.get_mao())
            {
                Console.WriteLine(carta.ToString());
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey();
        }    

        public static void show_ganhador (string ganhador, string perdedor, bool empate)
        {
            if (empate == true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("---------------- !! EMPATE !! ---------------- ");
                Console.WriteLine("O jogador {0} e o jogador {1} ficaram com a mesma mão ", ganhador, perdedor);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.WriteLine("---------------------------------------------------");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("O jogador {0} ganhou e o jogador {1} perdeu ", ganhador, perdedor);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.WriteLine("---------------------------------------------------");
                Console.ReadKey();
            }
           
        }

        public static void show_desempatemesa(int nummaior, string jogador)
        {

            if (nummaior == 0)
            {
                Console.WriteLine("---------------- !! EMPATE !! ---------------- ");
                Console.WriteLine("As cartas maiores dos dois jogadores sãos iguais");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Como aconteceu um empate em razão das cartas da mesa");
                Console.WriteLine("Para desempatar será avaliado as cartas dos jogadores");
                Console.WriteLine("E o jogador {0} ganhou com pois tem a maior carta de valor {1}", jogador, nummaior);
                Console.WriteLine("---------------------------------------------------");
                Console.ReadKey();
            }
        }
    }
}