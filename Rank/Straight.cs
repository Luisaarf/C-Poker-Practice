//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class Straight : RankGuia
    {
        //----------------------------------------------------------------   
        //construtor de Straight
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public Straight (List<List<Carta>> l) : base (l) {}
        //----------------------------------------------------------------

        //Método avaliação que verifica se é ou não é um Straight
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis 
            bool boolstraight = false ;
            List<Carta> listTemp = new List<Carta>();
            //----------------------------------------------------------------
            
            //por 9 vezes: 
            for (int i = 1; i < 10; i++)
            {
                if (histo_copia[i].Count >= 1 && histo_copia[i + 1].Count >= 1 && histo_copia[i + 2].Count >= 1 
                    && histo_copia[i + 3].Count >= 1 && histo_copia[i + 4].Count >= 1)
                {
                    //é um straight 
                    boolstraight = true;
                }
                else if (histo_copia[10].Count >= 1 && histo_copia[11].Count >= 1 && histo_copia[12].Count >= 1 
                    && histo_copia[13].Count >= 1 && histo_copia[1].Count >= 1)
                {
                    //é um straight 
                    boolstraight = true;
                } 
            }

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (boolstraight == true) ? true : false ; 

        }
    }
}