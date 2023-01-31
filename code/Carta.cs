//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

//classe que representa uma carta

namespace JogoPoker
{
    //Classe pública Carta
    public class Carta
    {
        //----------------------------------------------------------------
        //Criação de três variáveis privadas
        private int valor; //1-13
        private int owner;  // 0- jogador, 1-mesa, 2-jogador
        private string naipe; //Espadas,Ouros,Paus,Copas

        //----------------------------------------------------------------
        //gets e sets
        public int get_value()
        {
            //da acesso ao valor
            return valor;
        }

        
        public string get_naipe()
        {
            //da acesso ao naipe
            return naipe;
        }

        public int get_owner()
        {
           //da acesso ao owner
           return owner;
        }

        //para alterar o valor do owner
        public void set_owner(int o)
        {
            owner = o;
        }

        //para alterar o valor do naipe
        public void set_naipe(string n)
        {
            naipe = n;
        }

        //para alterar valor 
        public void set_value(int v)
        {
            valor = v;
        }

        //----------------------------------------------------------------
        //----------------------------------------------------------------
        //Construtor com três parâmetros
        public Carta (int v, int o, string na)
        {  
            //atribui os valores dos parâmetros nas variáveis
            valor = v;
            owner = o;
            naipe = na;
        }

        //----------------------------------------------------------------
        //construtor para fazer uma cópia de um objeto
        //recebe por parâmetro um objeto
         public Carta (Carta c) 
        {
            valor = c.get_value();
            owner = c.get_owner();
            naipe = c.get_naipe();
        }
        //----------------------------------------------------------------
        // construtor sem parâmetros
        public Carta()
        {
            naipe = "";
            valor = 0;
            owner = 1;
        }
        //----------------------------------------------------------------
        //polimorfismo
        //sobrecarga do método ToString
        //retorna uma cadeia de caracteres
        //transforma o objeto em string
        //representação em texto dos objetos
        //esse método é posteriormente chamado na classe show para escrever na tela cada carta e a quem pertence
        public override string ToString()
        {
            string card_text = "Naipe: " + naipe;
            card_text += "\tValor: " + valor;
            card_text += "\tOwner: " + owner;            
            return  card_text;
        }  
        //----------------------------------------------------------------
    }
}