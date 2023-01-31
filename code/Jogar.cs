//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

//Classe que será utilizada para fazer todo o jogo

namespace JogoPoker
{
    public class Jogar
    {
        //----------------------------------------------------------------
        //declaração de variáveis da classe jogar
        private List<Carta> avaliar_p1, avaliar_p2, listatemp;
        private Histograma histo1, histo2, histocroupier;
        private List<List<Carta>> histo1_2, histo2_2, histocroupier_1;
        private Croupier croupier;
        private Pessoa p1;
        private Pessoa p2;
        private Ranking rankjogo1, rankjogo2, rankcroupier;
        public string player1 = "p1";
        public string player2 = "p2";
        private string rankdop1;
        private string rankdop2;
        private bool empate;
        private int numeroclassif;
        private int numeroclassif2;
        private int maiorp1 = 0;
        private int maiorp2 = 0;



        //----------------------------------------------------------------
        //----------------------------------------------------------------
        //método construtor
        public Jogar()
        {
            croupier = new Croupier();
            p1 = new Pessoa("P1");
            p2 = new Pessoa("P2");
            rankdop1 = "";
            rankdop2 = "";

            avaliar_p1 = new List<Carta>();
			avaliar_p2 = new List<Carta>();
            listatemp = new List<Carta>();

            histo1 = new Histograma(avaliar_p1);
            histo2 = new Histograma(avaliar_p2);
            histo1_2 = new List<List<Carta>>();
            histo2_2 = new List<List<Carta>>();
            histocroupier = new Histograma(croupier.get_mesa());
            histocroupier_1 = new List<List<Carta>>();
            

            rankjogo1 = new Ranking(histo1_2);
            rankjogo2 = new Ranking(histo2_2);
            rankcroupier = new Ranking(histocroupier_1);
            empate = false;

        }

        //----------------------------------------------------------------
        // função "inicio" responsável por criar as cartas da mesa e dos jogadores 1 e 2
        public void inicio()
        {
            //Chama métodos da classe croupie para...
            croupier.create_cards(); // criar as cartas,
            croupier.shuffle(); //para embaralhar
            croupier.set_deck(); //e organizar as cartas no deck

            //----------------------------------------------------------------
            //cria as duas cartas do p1 e depois do p2 dessa forma: 

            //por 2 vezes ele repete:
            for (int i = 0 ; i < 2 ; i++)
            {
                //retira uma carta do deck 
                Carta temp = new Carta(croupier.get_cartadodeck());
                temp.set_owner(0); //muda o dono dessa carta para 0 (p1)
                p1.set_card(temp); //coloca essa carta na mão do p1

            }

            //e faz o mesmo para o p2:
            for (int i = 0 ; i < 2 ; i++)
            {
                Carta temp = new Carta(croupier.get_cartadodeck());
                temp.set_owner(2);
                p2.set_card(temp);

            }
            //----------------------------------------------------------------
            //chama a classe do croupier para colocar 5 cartas na mesa
            croupier.set_mesa();

        }

        //----------------------------------------------------------------
        //essa função serve apenas para chamar outra da classe show com os parâmetros retirados dessa classe
        public void show_jogo()
        {
            Show.showJogo(croupier, p1, p2);
        }

        //----------------------------------------------------------------
        //Essa função junta as listas da mão do p1 e p2 com a mesa
        public void juntaascartas()
        {   
            //adiciona as cartas da mesa e depois da mão para a lista avaliar_p1             	
        	avaliar_p1.AddRange(croupier.get_mesa());
            avaliar_p1.AddRange(p1.get_mao());

            //adiciona as cartas da mesa e depois da mão para a lista avaliar_p2
            avaliar_p2.AddRange(croupier.get_mesa());
            avaliar_p2.AddRange(p2.get_mao());
        } 


        //----------------------------------------------------------------
        //Já essa função ela monta o histograma
        public void montarhisto()
        {
            //Para cada jogador:
            // 1- ele cria um objeto do histograma com as cartas (jogador+mesa)
            // 2- para as duas listas ele chama função da classe histograma para classificar 
            // 3- armazena esse histograma que é uma lista de listas em uma outra variável dessa classe "Jogar"
            histo1 = new Histograma(avaliar_p1);
            histo1.count_values();
            histo1_2 = histo1.get_histogram();
            histo2 = new Histograma(avaliar_p2);
            histo2.count_values();
            histo2_2 = histo2.get_histogram();
            //----------------------------------------------------------------
            
            // Por fim, chama o método estático de show para mostrar os dois histogramas ...
            // ... que são "enviados" pelos parâmetros
            Show.show_histojogo(histo1_2, histo2_2);
        }

        //----------------------------------------------------------------
        //função para analisar os dois histogramas (histo1_2 e histo2_2) para definir qual a mão de cada um
        public void rankingjogo()
        {
            //Para cada jogador são criados objetos na classe ranking que levam os histogramas como parâmetro
            Ranking rankjogo1 = new Ranking(histo1_2);
            Ranking rankjogo2 = new Ranking(histo2_2);
            //----------------------------------------------------------------
            rankjogo1.analisarmao(); //chama o método para analisar qual a mão do primeiro jogador
            //Mostra a mão do jogador 1 na tela e leva como parâmetros : 
            // o string da mão do jogador, a string para mostrar que se trata do player 1..
            // e o valor da carta mais alta, caso precise usa-la como desempate
            Show.show_rankjogo(rankjogo1.get_result(), player1, rankjogo1.get_valordacarta());
            //----------------------------------------------------------------
            rankjogo2.analisarmao(); //chama o método para analisar qual a mão do segundo jogador
            //Mostra a mão do jogador 2 na tela e leva como parâmetros : 
            // o string da mão do jogador, a string para mostrar que se trata do player 2..
            // e o valor da carta mais alta, caso precise usa-la como desempate
            Show.show_rankjogo(rankjogo2.get_result(), player2, rankjogo2.get_valordacarta());
            //----------------------------------------------------------------
            // armazena na variável local o número relacionado com a mão para poder ser usado na comparação depois
            numeroclassif = rankjogo1.get_numverif();
            numeroclassif2 = rankjogo2.get_numverif();
            //----------------------------------------------------------------
            
        }
        public void EmpateMesa()
        {
            int p1numempatemesa_1 = p1.get_cardvalue(0);
            int p1numempatemesa_2 = p1.get_cardvalue(1);
            int p2numempatemesa_1 = p2.get_cardvalue(0);
            int p2numempatemesa_2 = p2.get_cardvalue(1);

            if (p1numempatemesa_1 > p1numempatemesa_2)
            {
                maiorp1 = p1numempatemesa_1;
            }
            else
            {
                maiorp1 = p1numempatemesa_2;
            }

            if (p2numempatemesa_1 > p2numempatemesa_2)
            {
                maiorp2 = p2numempatemesa_1;
            }
            else
            {
                maiorp2 = p2numempatemesa_2;
            }

            if ( maiorp1 > maiorp2)
            {
                Show.show_desempatemesa(maiorp1, player1);
            }
            else if ( maiorp2 > maiorp1)
            {
                Show.show_desempatemesa(maiorp2, player2);
            }
            else
            {
                Show.show_desempatemesa(0, "empate");
            }
            
        }
        //----------------------------------------------------------------
        // método para comparar e definir quem ganhou e quem perdeu
        public void quemganhou()
        {
            //se o número do primeiro for menor que o do segundo
            if ( numeroclassif < numeroclassif2)
            { 
                //chama o método para mostrar o ganhador 
                //a ordem dos parâmetros que define isso (ganhador, perdedor, se é um empate ou não)
                Show.show_ganhador(player1, player2, empate);
                //jogador p1 ganhou //player1
            }
            //se o número do primeiro for maior que o do segundo
            else if (numeroclassif > numeroclassif2)
            {
                //chama o método para mostrar o ganhador 
                //a ordem dos parâmetros que define isso (ganhador, perdedor, se é um empate ou não)
                Show.show_ganhador(player2, player1, empate);
                //jogador p2 ganhou //player2
            }
            else //se nenhum for maior que o outro então os dois são iguais
            {
                listatemp.AddRange(croupier.get_mesa());
                histocroupier = new Histograma(listatemp);
                histocroupier.count_values();
                histocroupier_1 = histocroupier.get_histogram();
                Ranking rankcroupier = new Ranking(histocroupier_1);
                rankcroupier.analisarmao();
                int numcroupier = rankcroupier.get_numverif();
                if (numeroclassif == numcroupier)
                {
                    EmpateMesa();
                }
                else
                {
                    empate = true; // então empate é verdadeiro 
                    //if (numeroclassif == )
                    Show.show_ganhador(player1, player2, empate); //chama método show para mostrar o empate
                    //nessa ocasião tanto faz a ordem do player 1 e do player dois pois foi empate
                    //empate

                }
            }
            
            
        }
        
    }
}