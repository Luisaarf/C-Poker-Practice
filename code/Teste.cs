//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados

//classe para fazer testes de reconhecimento

namespace JogoPoker
{
    public class Teste
    {
        private List<Carta> card_list;

        //----------------------------------------------------------------
        //método construtor      
        public Teste()
        {
            card_list = new List<Carta>();
        
        }
        //----------------------------------------------------------------

        // da acesso a lista de cartas
        public List<Carta> get_cards()
        {
            return card_list;
        }

        //----------------------------------------------------------------

        // invoca um método estático da classe load responsável por ler os arquivos
        // atribui a lista criada a variável de instância <card_list>
        public void load_cards()
        {
            card_list = Load.load_hand();
        }

    }//fim do escopo da classe
}