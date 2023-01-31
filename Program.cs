//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados

namespace JogoPoker
{   
    class Program
    {   
        //ponto de entrada do programa, onde começa a execução

        //Função principal
        static void Main(string[] args)
        {
            // declaração da variável go - que faz a repetição do código, ou não
            // declaração da variável option - para armazenar a resposta do usuário
            bool go = true;
            int option = 0;
            Console.Clear(); //Limpa o console

            //------------------------------------------------------------------
            //loop principal 

            while(go)  //enquanto go for true o programa continua rodando
            {
                Show.show_menu();  //chama o método show_menu da classe Show
                //método estático não precisa de objeto para ser chamado
              
                option = get_option();  //método que retorna valor para ser armazenado em option

                //analisa a variável option
                //essa instrução escolhe um dos casos a ser executado dependendo do que está armazenado
                switch (option)
                {

                    //----------------------------------------------------------
                    case 1:     // se option for igual a 1

                        //demosntração da classe <Croupier>
                        #region Croupier_ 
                        //Region serve para compartimentar regiões do código
                        /*
                        Croupier croupier = new Croupier(); //instancia objeto croupier da classe croupier
                        croupier.creat_cards(); //chama método creat_cards 
                        Show.show_cards(croupier.get_list()); // chama método get_list e show_cards

                        croupier.shuffle(); //chama método shuffle para embaralhar
                        croupier.set_deck();
                        
                        for (int i = 0; i < 52; i++)
                        {
                            Carta card_tmp = new Carta(croupier.get_card());
                            Console.WriteLine(card_tmp.ToString());                            
                        }
                        Console.ReadKey();
                        */
                        #endregion

                        //região para execução do test
                        #region Test
                        
                        Teste test = new Teste(); // cria objeto test da classe teste
                        test.load_cards(); //chama método load_cards responsável por carregar o arquivo
                        Show.show_cards(test.get_cards()); //chama dois métodos para mostrar as cartas na tela
                        //um para dar acesso as cartas e o outro para colocar na tela

                        //Constrói um histograma das cartas
                        Histograma histo = new Histograma(test.get_cards());
                        histo.count_values(); //método que cria e a estrutura do histograma
                        Show.show_histogram(histo.get_histogram()); //chama dos métodos para mostrar o histograma

                        //Cria um ranking das mãos
                        Ranking rank = new Ranking(histo.get_histogram());
                        rank.analisarmao();
                        Show.show_rank(rank.get_result()); //chama dos métodos para mostrar o rank
                        //um para dar acesso ao histograma e o outro para colocar na tela
                        Show.show_cartaalta(rank.get_valordacarta()); //mostra qual a carta mais alta


                        //fim da região
                        #endregion

                        break; //instrução que interrompe o switch
                    //----------------------------------------------------------
                    //----------------------------------------------------------
                    case 2:  // se option for igual a 2

                        //cria um objeto jogo da classe jogar
                        Jogar jogo = new Jogar();
                        jogo.inicio(); //esse função cria as cartas do jogo e distribui entre jogadores e mesa
                        jogo.show_jogo(); //essa vai ser responsável por mostrar essa distribuição
                        jogo.juntaascartas(); //aqui as cartas dos jogadores se juntam com as da mesa para avaliar as mãos
                        jogo.montarhisto(); //os histogramas são criados e mostrados na tela
                        jogo.rankingjogo(); //analisando os histogramas essa função retorna qual a mão de casa jogador
                        jogo.quemganhou(); //essa última função mostra quem ganhou comparando a mão dos dois jogadores
             
                        break; //instrução que interrompe o switch
                    //----------------------------------------------------------
                    //----------------------------------------------------------
                    //caso o valor armazenado em option não corresponda a nenhum dos cases
                    default:
                        break; //instrução que interrompe o switch
                    //----------------------------------------------------------
                } //fim do switch
                
    			Show.show_restart(); //chama método show_restart da classe show
                option = get_option(); //chama método get_option
                
                // expression (true or false) ? (in true case) : (in false case)
                //go(option == 2) //caso for verdadeiro (false) : caso for falso (true)
                //se o que tiver armazenado em option for 2 ele coverte em false e armazena 
                //false no go para não repetir novamente
                //se o que tiver armazenado em option não for 2 ele converte em true e então o loop reinicia
                go = option == 2 ? false : true;
                
            }            
        } //fim do escopo da função principal

        //----------------------------------------------------------------------
        //método estático da classe Program
        public static int get_option()
        {
            int opt = 0; //variável do método que será usado para retornar um valor
                              
            while (true) //loop infinito, só para com o break
            {
                //conversão de int para string
                Int32.TryParse(Console.ReadLine(), out opt); //opt = int(string)

                if(opt >= 1 && opt <= 2)   //se for maior ou igual a 1 e menor e igual a 2
                    break; //para o loop
                else //se não:
                    Console.WriteLine("Valid options: 1 or 2");
            }

            return opt;  //retorna opt


        } // fim do escopo do método


    }
}


