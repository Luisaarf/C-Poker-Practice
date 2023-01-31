//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class ThreeofaKind : RankGuia
    {
        //----------------------------------------------------------------   
        //construtor do Three Of A Kind
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public ThreeofaKind (List<List<Carta>> l) : base(l) {}
        //----------------------------------------------------------------
        //Método avaliação que verifica se é ou não é um Three of a Kind
        public override bool avaliacao() 
        {
            //----------------------------------------------------------------
            // declaração da variável
            bool boolthreeofakind = false;
            //----------------------------------------------------------------

            //verifica cada lista da lista do histograma (cada índice)
            foreach(var listaind in histo_copia)
			{
				//se em algum índice tiver três cartas é um three of a kind
				if(listaind.Count == 3)
				{
                    boolthreeofakind = true;
                }
            }

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (boolthreeofakind == true) ? true : false ;
        }
        
    }
}