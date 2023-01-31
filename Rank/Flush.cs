//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 
namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class Flush : RankGuia
    {
        //----------------------------------------------------------------   
        //construtor de royal flush 
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public Flush (List<List<Carta>> l) : base(l) { }
        //----------------------------------------------------------------

        //Método avaliação que verifica se é ou não é um Flush
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis 
            bool boolflush = false;
            int contCopas = 0;
            int contOuros = 0;
            int contPaus = 0;
            int contEspadas = 0;

            List<Carta> tempList = new List<Carta>();
            //----------------------------------------------------------------

            //loop responsável por ler todos as listas da lista
            foreach (var listaind in histo_copia)
            {
                //se o número de elemento no respectivo índice for maior ou igual a 1
                if (listaind.Count >= 1)
                {
                    //cada carta desse indice é adicionado em uma lista temporária
                    foreach (var carta in listaind)
                    {
                        tempList.Add(carta);
                    }
                }
            }
            //loop para ler quantos naipes tem na lista de cartas temporária
            foreach (var carta in tempList)
            {
                if (carta.get_naipe() == "Copas" || carta.get_naipe() == "Hearts" )
                {contCopas++;}
                if (carta.get_naipe() == "Ouros" || carta.get_naipe() == "Diamonds" )
                {contOuros++;}
                if (carta.get_naipe() == "Paus" || carta.get_naipe() == "Clubs" )
                {contPaus++;}
                if (carta.get_naipe() == "Espadas" || carta.get_naipe() == "Spades" )
                {contEspadas++;}
            }

            //se algum dos contadores for igual a 5 é um flush
            if (contCopas == 5 || contEspadas == 5 || contOuros == 5 || contPaus == 5) {boolflush = true;}

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (boolflush == true ) ? true : false;
        }
    }
}