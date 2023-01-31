//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class RoyalFlush : RankGuia
    {
        //----------------------------------------------------------------   
        //construtor de royal flush 
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public RoyalFlush(List<List<Carta>> l) : base(l) { } 
        //----------------------------------------------------------------

        //Método avaliação que verifica se é ou não é um Royal Flush
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis 
            bool boolroyalflush = false;
            int contCopas = 0;
            int contOuros = 0;
            int contPaus = 0;
            int contEspadas = 0;     

            List<Carta> listTemp = new List<Carta>();
            List<Carta> royalLista = new List<Carta>();
            //----------------------------------------------------------------

            //se tiver uma  e apenas uma carta 1,13,12,11,10 na lista::
            if (histo_copia[1].Count >= 1 && histo_copia[13].Count >= 1 && histo_copia[12].Count >= 1 && histo_copia[11].Count >= 1 && histo_copia[10].Count >= 1)
            {
                //para todos elementos no indice "x" adiciona os elementos na lista temporária
                foreach (var carta in histo_copia[10])
                    listTemp.Add(carta);
                    
                foreach (var carta in histo_copia[11])
                    listTemp.Add(carta);

                foreach (var carta in histo_copia[12])
                    listTemp.Add(carta);

                foreach (var carta in histo_copia[13])
                    listTemp.Add(carta);

                foreach (var carta in histo_copia[1])
                    listTemp.Add(carta);
            }       

            //loop responsavel por ler toda a lista temporária 
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
            
            //após analisar a quantidade de cartas de cada naipe aqui ele vai criar uma lista com o resultado final
            //adiciona as cartas do respectivo naipe na lista royalList

            //se o contador de copas for maior ou igual a 5 
            if (contCopas >= 5 )
            {
                boolroyalflush = true;
            }
            
            //se o contador de paus for maior ou igual a 5 
            if (contPaus >= 5)
            {
                boolroyalflush = true;
            }

            //se o contador de ouros for maior ou igual a 5 
            if (contOuros >= 5)
            {
                boolroyalflush = true;
            }

            //se o contador de espadas for maior ou igual a 5 
            if (contEspadas >= 5)
            {
                boolroyalflush = true;
            }
            
            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (boolroyalflush == true ) ? true : false;
        }

    }
}