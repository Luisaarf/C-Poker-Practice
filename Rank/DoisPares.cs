//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class DoisPares : RankGuia
    {
        //----------------------------------------------------------------   
        //construtor de dois pares 
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public DoisPares (List<List<Carta>> l ) : base(l) {}
        //----------------------------------------------------------------  
        
        //Método avaliação que verifica se é ou não caso de Dois Pares
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis
            bool booldoispares = false;
            int pares = 0;
            //----------------------------------------------------------------

            //verifica cada lista da lista do histograma (cada índice)
            foreach(var listaind in histo_copia)
			{
                //se em algum índice tiver uma dupla soma mais um na variável pares
				if(listaind.Count >= 2)
				{
					pares++;	
				}
            } 

            //se forem dois pares o bool da mão é verdadeiro
            if (pares >= 2)
            {
                booldoispares = true;
            }

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (booldoispares == true) ? true : false;
        }
    }
}