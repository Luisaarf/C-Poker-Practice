//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class UmPar : RankGuia
    {
        //----------------------------------------------------------------   
        //construtor de dois pares 
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public UmPar (List<List<Carta>> l ) : base(l) {}
        //---------------------------------------------------------------- 

        //Método avaliação que verifica se é ou não caso de Um Par 
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis
            bool boolumpar = false;
            int pares = 0;
            //----------------------------------------------------------------

            //para cara indice no histograma
            foreach(var listaind in histo_copia)
			{
                //se a lista do indice tiver mais que dois elementos
				if(listaind.Count >= 2)
				{
                    //adiciona mais um em pares
					pares++;	
				}
            } 
            
            //se tiver um par o bool de um par é verdadeiro
            if (pares == 1)
            {
                boolumpar= true;
            }

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (boolumpar == true)? true : false ;
        }
    }
}