//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

//classe que define o ranking da mão

//----------------------------------------------------------------

namespace JogoPoker
{
    public class Ranking
    {
        //declaração de variáveis
        private string result;
        private int verif;
        private bool cartaAltabool = false;

        private int valcarta;
        private List<List<Carta>>histo_copia;
        //----------------------------------------------------------------
        //método construtor que recebe como parâmetro um histograma (uma lista de listas)
        public Ranking(List<List<Carta>> histo)
		{ 
            result = "";
            histo_copia = new List<List<Carta>>(histo);
        }
        //----------------------------------------------------------------

        //método que através do histograma vai verificar qual é a mão
        public void analisarmao()
        {             
            //int pararloop = 0;
            //loop para analisar a mão e verificar se corresponde a algum rank
            for (int i = 0; i < 11; i++)
            {     
                switch(i)
                {
                    //----------------------------------------------------------------
                    //Em todos os casos:
                    //Pega o valor de NomesMaos.Tipodamao e converte para tipo int
                    //Cria um novo objeto dentro da classe da mão e leva como parâmetro uma cópia da lista do histograma
                    //verifica se é aquela mão e se sim atribui o nome do rank no resultado e troca o i para 11
                    //a variável verif ela ganha o número que corresponde a mão no ranking (de 1 a 10) para poder ser usado depois
                    //----------------------------------------------------------------

                    case (int)NomesMaos.RoyalFlush:
                        RoyalFlush royalFlush = new RoyalFlush(histo_copia);
                        if (royalFlush.avaliacao())
                        {
                            i = 11;
                            result = "Royal Flush";
                            verif = 1;
                        }
                        break;
                    case (int)NomesMaos.StraightFlush:
                        StraightFlush straightFlush = new StraightFlush(histo_copia);                            
                        if (straightFlush.avaliacao())
                        {
                            i= 11;
                            result = "Straight Flush";
                            verif = 2;
                        }
                        break;
                    case (int)NomesMaos.FourofaKind:
                        FourofaKind fourofaKind = new FourofaKind (histo_copia);                            
                        if (fourofaKind.avaliacao())
                        {
                            i= 11;
                            result = "Four of a Kind";
                            verif = 3;
                        }
                        break;
                    case (int)NomesMaos.FullHouse:
                        FullHouse fullHouse = new FullHouse(histo_copia);                            
                        if (fullHouse.avaliacao())
                        {
                            i= 11;
                            result = "Full House";
                            verif = 4;
                        }
                        break;
                    case (int)NomesMaos.Flush:
                        Flush flush = new Flush(histo_copia);                            
                        if (flush.avaliacao())
                        {
                            i= 11;
                            result = "Flush";
                            verif = 5;
                        }
                        break;
                    case (int)NomesMaos.Straight:
                        Straight straight = new Straight(histo_copia);                            
                        if (straight.avaliacao())
                        {
                            i= 11;
                            result = "Straight";
                            verif = 6;
                        }
                        break;
                    case (int)NomesMaos.ThreeofaKind:
                        ThreeofaKind threeofakind = new ThreeofaKind(histo_copia);                            
                        if (threeofakind.avaliacao())
                        {
                            i= 11;
                            result = "Three of a Kind";
                            verif = 7;
                        }
                        break;
                    case (int)NomesMaos.DoisPares:
                        DoisPares doisPares = new DoisPares(histo_copia);                            
                        if (doisPares.avaliacao())
                        {
                            i= 11;
                            result = "Dois Pares";
                            verif = 8;
                        }
                        break;
                    case (int)NomesMaos.UmPar:
                        UmPar umPar = new UmPar(histo_copia);                            
                        if (umPar.avaliacao())
                        {
                            i= 11;
                            result = "Um Par";
                            verif = 9;
                        }
                        break;
                    case (int)NomesMaos.CartaMaisAlta:
                        CartaMaisAlta cartaMaisAlta = new CartaMaisAlta(histo_copia);                            
                        if (cartaMaisAlta.avaliacao())
                        {
                            i= 11;
                            result = "Carta mais Alta" ;
                            //bool para confirmar que se trata de mão de Carta Mais Alta
                            cartaAltabool = true;
                            //chama procedimento que retorna o valor da carta da lista
                            valcarta = cartaMaisAlta.acarta() ;
                            verif = 10;

                        }
                        break;
                    default:
                        result = "Não identificado";
                        break;
                
                }
                
            }
        }

        //----------------------------------------------------------------
        //gets
        
        //função que retorna o valor da carta mais alta
        public int get_valordacarta()
        {
            //se a mão depender da carta mais alta ele retorna o valor da carta
            if (cartaAltabool == true)
            {
                return valcarta;
            }
            else //se não ele retorna o valor 0
            {
                return  0 ; 
            }

        }
        
        public string get_result()
		{return result;}

        public int get_numverif()
        { return verif; }

        //----------------------------------------------------------------
    }
} 
