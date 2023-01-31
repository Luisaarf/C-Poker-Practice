//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class FourofaKind : RankGuia
    {
        //----------------------------------------------------------------
        //construtor do Four of a King
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public FourofaKind(List<List<Carta>> l) : base(l) { }
        //----------------------------------------------------------------
        //Método avaliação que verifica se é ou não é um four of a kind
        public override bool avaliacao ()
        {
            //----------------------------------------------------------------
            // declaração da variável
            bool boolfourofakind = false;
            //----------------------------------------------------------------

            //verifica cada lista da lista do histograma (cada índice)
            foreach(var indlista in histo_copia)
            {
                //para cada lista de listas do histograma ver se tem mais de 4 elementos
                if(indlista.Count >= 4)
                {
                    boolfourofakind = true;
                }
            }

            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return (boolfourofakind == true ) ? true : false;
        }
    }
}