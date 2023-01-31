//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

namespace JogoPoker
{
    //essa classe é filha da classe RankGuia, ela recebe todos atributos e métodos da classe mãe
    public class CartaMaisAlta : RankGuia
    {
        //----------------------------------------------------------------   
        //construtor de carta mais alta 
        // aqui recebe a lista (histo_copia) entendido como "1", usando base(1), ele chama a classe base RankGuia
        public CartaMaisAlta (List<List<Carta>> l) : base(l) {}
        //----------------------------------------------------------------

        //Método avaliação que verifica a carta mais alta 
        //aqui o cuidado é com a carta 1  que é a carta mais valiosa do jogo
        public override bool avaliacao()
        {
            //----------------------------------------------------------------
            // declaração de variaveis
            bool temum = false;
            List<Carta> listaTemp = new List<Carta>();
            List<Carta> aCartaMaior = new List<Carta>();
            //----------------------------------------------------------------

            //verifica todas as listas dentro do histograma
            foreach (var listaind in histo_copia)
            {
                //se tiver mais de uma e for o índice 1
                if (listaind.Count >= 1 && listaind == histo_copia[1])
                {
                   temum = true; //tem uma carta um
                   foreach (var carta in histo_copia[1])
                    {
                        aCartaMaior.Add(carta);
                    }
                   
                }   
                //toda carta existente é adicionada em uma lsita temporária
                if (listaind.Count >= 1) 
                {
                    foreach (var carta in listaind)
                    {
                        listaTemp.Add(carta);
                    }
                }    
            }
            //----------------------------------------------------------------

            //cria um objeto maior da classe Carta
            Carta maior = new Carta();
            
            //loop responsável por percorrer todos os elementos da lista temporária
            for (int i = 0; i < listaTemp.Count; i++)
            {
                //se o elemento desse indíce tiver valor maior que o valor armazenado no valor do objeto maior
                if (listaTemp[i].get_value() > maior.get_value())
                {
                    maior = listaTemp[i];
                }
            }
            //----------------------------------------------------------------
            //se tiver alguma carta 1
            if(temum)
            {
                //o valor da carta em maior é igual a um
                maior.set_value(1) ;
            } 
            //----------------------------------------------------------------
            //retornar : (a variavel é verdadeira ?) se sim retorna true : se não retorna false
            return ((maior.get_value() >= 1) == true) ? true: false ;
        }

        //método para conseguir o valor da carta
        public int acarta()
        {
            //----------------------------------------------------------------
            // declaração de variaveis 
            bool temum = false;
            List<Carta> acartamaior2 = new List<Carta>();
            List<Carta> listTemp = new List<Carta>();
            //----------------------------------------------------------------
            //conseguir a carta maior dnv:
            foreach (var listaind in histo_copia)
            {
                if (listaind.Count >= 1 && listaind == histo_copia[1])
                {
                   temum = true;
                } 
                if (listaind.Count >= 1)
                {
                    foreach (var carta in listaind)
                    {
                        listTemp.Add(carta);
                    }
                }    
            }

            Carta maior = new Carta();
            
            //loop responsável por percorrer todos os elementos da lista temporária
            for (int i = 0; i < listTemp.Count; i++)
            {
                //se o elemento desse indíce tiver valor maior que o valor armazenado no valor do objeto maior
                if (listTemp[i].get_value() > maior.get_value())
                {
                    maior = listTemp[i];
                }
            }

            if(temum)
            {
                maior.set_value(1) ;
            } 
            //----------------------------------------------------------------

            acartamaior2.Add(maior);

            //retorna o valor da carta
            return Convert.ToInt32(acartamaior2[0].get_value()) ; 
        }
    }
}