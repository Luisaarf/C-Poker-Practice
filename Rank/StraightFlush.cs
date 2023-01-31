//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class StraightFlush : RankGuia
    {
        //----------------------------------------------------------------
        //construtor do Straight Flush
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public StraightFlush (List<List<Carta>> l) : base (l) {}

        //----------------------------------------------------------------

        //Método avaliação que verifica se é ou não é um Straight Flush
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis
            bool boolstraight = false;
            bool boolstraightflush = false;
            int contCopas = 0;
            int contOuros = 0;
            int contPaus = 0;
            int contEspadas = 0;

            List<Carta> listTemp = new List<Carta>();
            //----------------------------------------------------------------

            //por 9 vezes :   
            //(1,2,3,4,5) (2,3,4,5,6) (3,4,5,6,7) (4,5,6,7,8) (5,6,7,8,9) (6,7,8,9,10) (7,8,9,10,11) (8,9,10,11,12) (9,10,11,12,13)
            //(10,11,12,13,1) já é um royal flush então não é incluso
            for (int i = 1; i < 10; i++)
            {
                if (histo_copia[i].Count >= 1 && histo_copia[i + 1].Count >= 1 && histo_copia[i + 2].Count >= 1 
                    && histo_copia[i + 3].Count >= 1 && histo_copia[i + 4].Count >= 1)
                {
                    //é um straight já
                    boolstraight = true;

                    //por todas as cartas no índice coloca na lista listTemp
                    foreach (var carta in histo_copia[i])
                        listTemp.Add(carta);
                    
                    foreach (var card in histo_copia[i+1])
                        listTemp.Add(card);

                    foreach (var card in histo_copia[i+2])
                        listTemp.Add(card);

                    foreach (var card in histo_copia[i+3])
                        listTemp.Add(card);

                    foreach (var card in histo_copia[i+4])
                        listTemp.Add(card);

                }
            }

            //loop responsavel por ler toda a lista temporária 
            //verifica o naipe da respectiva carta da lista 
            //e adiciona mais 1 ao devido contador
            foreach (var carta in listTemp)
            {
                //verifica o naipe de cada carta
                if (carta.get_naipe() == "Copas" || carta.get_naipe() == "Hearts" )
                {contCopas++;}
                if (carta.get_naipe() == "Ouros" || carta.get_naipe() == "Diamonds" )
                {contOuros++;}
                if (carta.get_naipe() == "Paus" || carta.get_naipe() == "Clubs" )
                {contPaus++;}
                if (carta.get_naipe() == "Espadas" || carta.get_naipe() == "Spades" )
                {contEspadas++;}
            }

            //se for um straight e conter 5 cartas de um naipe
            if (boolstraight == true && (contCopas >= 5 || contOuros >= 5 || contOuros >= 5 || contEspadas >= 5))
            {
                //é um straight flush
                boolstraightflush = true;
            }

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (boolstraightflush == true ) ? true : false;

        }
    }
}