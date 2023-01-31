//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

//Classe que representa o Croupier

namespace JogoPoker
{
    //Classe pública Croupier
    public class Croupier
    {
        //variáveis de instância 
        //lista e pilha
        private List<Carta> card_list;
        private Stack<Carta> deck;
        private List<Carta> mesa;
    
        //----------------------------------------------------------------    
        //Declaração do construtor 
        // inicializa as variáveis de instância nos objetos criados
        public Croupier()
        {
            card_list = new List<Carta>();
            deck = new Stack<Carta>();
            mesa = new List<Carta>();
        }    
        //----------------------------------------------------------------

        //Função que cria as cartas  //São 52 cartas - 13 cartas de cada naipe
        public void create_cards()
        {   
            //criação de todas as cartas do deck
            for (int i = 0 ; i < 13 ; i++)
            {
                //cria listas para ter 13 cartas de cada naipe
                Carta c1 = new Carta((i+1), 1, "Paus");
                Carta c2 = new Carta((i+1), 1, "Ouros");
                Carta c3 = new Carta((i+1), 1, "Copas");
                Carta c4 = new Carta((i+1), 1, "Espadas");

                //coloca todas as cartas na mesma lista
                card_list.Add(c1);
                card_list.Add(c2);
                card_list.Add(c3);
                card_list.Add(c4);
            }
        }

        //----------------------------------------------------------------

        //Função responsavel por enbaralhar as cartas 
        public void shuffle()
        {
            // Cria um objeto na classe random
            Random rnd = new Random();
            
            //começa pelo ultimo elemento e troca um por um
            // o i>0 pois não é preciso pegar o primeiro elemento
            for (int i = card_list.Count - 1; i > 0; i--)
            {                
                // pega um índice aleatório de 0 a i+1
                int j = rnd.Next(0, i+1);
                
                //Coloca o elemento em um índice aleatório
                Carta temp = new Carta (card_list[i]);
                card_list[i] = card_list[j];
                card_list[j] = temp;
            }      
        }
        //----------------------------------------------------------------
        //gets e sets
        
        // pega as cartas da lista (após o shuffle)
        // e as insere no deck que é uma pilha
        public void set_deck ()
        {
            for (int i = 0 ; i < card_list.Count ; i++)
            {
                deck.Push(card_list[i]);
            }
        }

       //fornece acesso a carta tirando ela do deck
        public Carta get_card()
        {
            return deck.Pop();
        }

        //fornece acesso a lista de cartas
        public List<Carta> get_list()
        { return card_list; }

        //fornece acesso a lista de cartas da mesa
        public List<Carta> get_mesa()
        { return mesa;}

        //fornece uma carta retirada do deck
        public Carta get_cartadodeck()
        {return deck.Pop();}

        //define as cartas da mesa
        public void set_mesa()
        {
            //por 5 vezes ele retira uma carta da pilha deck e coloca na lista mesa
            for (int i = 0 ; i < 5 ; i++)
            {
                mesa.Add(deck.Pop());
            }
        }

        //----------------------------------------------------------------
    }
}