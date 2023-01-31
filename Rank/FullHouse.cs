//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class FullHouse : RankGuia
    {
        //----------------------------------------------------------------
        //construtor do Full House
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public FullHouse (List<List<Carta>> l) : base(l) { }
        //----------------------------------------------------------------

        //Método avaliação que verifica se é ou não é um Full House
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis
            bool par = false;
            bool trinca = false;
            //----------------------------------------------------------------

            //para cada lista dentro da lista
            foreach(var listaind in histo_copia)
			{
                //se a quantidade de elementos no índice for 2 e o a váriavel par for falsa
                if(listaind.Count == 2 && par == false)
                {
                    par = true;				
                }
                //se a quantidade de elementos no índice for 3 e o a váriavel trinca for falsa
                if(listaind.Count == 3 && trinca == false)
                { 
                    trinca= true;				
                } 
				
			}

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (par == true && trinca == true) ? true : false;
        }
    }
}