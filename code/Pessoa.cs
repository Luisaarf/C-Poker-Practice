//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados

namespace JogoPoker
{
    //Classe pública Pessoa
    public class Pessoa
    {
        //Declaração das variáveis de instância
        private string nome;
        private List<Carta> mao;
    
        //Construtor
        public Pessoa (string n)
        {
            nome = n;
            mao = new List<Carta>();
        }

        //da acesso ao nome
        public string get_name()
        {
            return nome;
        }

        //da acesso a lista
        public List<Carta> get_mao()
        {
            return mao;
        }

        //adiciona um objeto Carta na mão da pessoa
        public void set_card(Carta c)
        {
            this.mao.Add(c);
        }

        public int get_cardvalue(int i)
        {
           int valor = mao[i].get_value();
           return valor;
        }

    }//fim do escopo da classe
}