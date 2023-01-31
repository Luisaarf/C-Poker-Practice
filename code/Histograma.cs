//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados 

//classe para fazer o histograma 

namespace JogoPoker
{
    public class Histograma
    {
        List<Carta> to_organize; // segura as cartas para organizar
		List<List<Carta>> histogram; // uma lista de listas para armazenar a estrutura do histograma

        //----------------------------------------------------------------
        //método construtor
		public Histograma(List<Carta> c_list)
		{
			to_organize = new List<Carta>(); //inicializa a lista
			foreach (var c in c_list) // para todo elemento em c_list
			to_organize.Add(new Carta(c)); //adiciona cada elemento (cópias de cartas) em to_organize 

			histogram = new List<List<Carta>>(); //inicializa a estrutura histograma

			for (int i = 0 ; i < 14 ; i++) //em uma sequência de 14 vezes
				histogram.Add(new List<Carta>()); //adiciona um histograma
		}
        //----------------------------------------------------------------

        //----------------------------------------------------------------
        //fazer quantificação para classificação
		//colocar as cartas na lista em um índice específico 
		//índice/ valor da carta
		public void count_values()
		{
			//Para organizar no histograma:   
			//cada carta na lista to_organize vai sendo adicionada em uma das listas na lista de lista 
			//en palavras mais fáceis ele liga o valor em to_organize com o valor no histograma para organizar os elementos
			for (int i = 0 ; i < to_organize.Count; i++ ) //em uma sequência de vezes igual ao número de elementos em to_organize
			{
				// a variável valor armazena o valor da carta que estava na lista to_organize na posição [i]
				int value = to_organize[i].get_value();
				//o valor da carta é usado para pegar posição do índice no histograma
				//o objeto analizado em to_organize é adicionado no histograma
				histogram[value].Add(new Carta(to_organize[i]));
			}
		}
        //----------------------------------------------------------------
        //dar acesso
		public List<List<Carta>> get_histogram()
		{return histogram;}

		public List<Carta> get_organized()
		{return to_organize;}

        //----------------------------------------------------------------

    }
}