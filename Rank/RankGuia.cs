//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

// essa classe vai servir de classe mãe para todas as mãos 

namespace JogoPoker
{
    //enum é uma classe especial que representa um número de constantes que não podem ser trocadas 
    //e que são lidas através de variáveis
    //todos os elementos do enum são separados por vírgulas
    public enum NomesMaos
	{
        RoyalFlush = 1,  //como esse foi atribuido 1 ele deixa de valer 0 e os próximos tem valor 2,3,4...
        StraightFlush,  // = 2
        FourofaKind, // =3
        FullHouse, // = 4 ...
        Flush,
        Straight,
        ThreeofaKind,
        DoisPares,
        UmPar,
        CartaMaisAlta
	}

    public abstract class RankGuia
    {
        // o protected permite acesso às classes filhas (diferente do private), mas proíbe a qualquer outro acesso externo
        protected List<List<Carta>> histo_copia;

        //aqui nesse construtor, ele recebe " Classerank nomeClasserank = new Classerank(histo_copia);"
        //histo_copia passa para a classe do rank que passa a mesma lista aqui
        public RankGuia (List<List<Carta>> lista)
        {
            histo_copia = new List<List<Carta>>(lista);
        }

        public abstract bool avaliacao ();
        
    }
}