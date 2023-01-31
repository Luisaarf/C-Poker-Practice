//Luísa Rodrigues Foppa, Pedro Augusto Facco Machado, Estrutura de Dados

//Classe responsável por ler os arquivos txt
namespace JogoPoker
{
    public class Load
    {
        //Essa função pede um caminho de arquivo
        //retorna uma lista de cartas criada pelo .txt]
        public static List<Carta> load_hand()
	    {
            
            List<Carta> cards = new List<Carta>(); //lista de cartas
            string path_file = Directory.GetCurrentDirectory(); //Pega o diretório atual e armazena em path_file
            Console.WriteLine("\nDigite o nome do arquivo"); 
            //adiciona ao diretório a pasta cards_files pra ele achar os arquivos
            path_file += "\\cards_files\\"; //path_file = path_file + "string"
            path_file += Console.ReadLine();//path_file = path_file + "string do arquivo txt"
            

            // a seguir é lida todas as linhas do arquivo e retorna em forma de array
            //toda posição do array corresponde a uma linha do arquivo            
             string[] readText = File.ReadAllLines(path_file);

            //toda linha no documento é igual a s
            foreach(var s in readText)
            {
                // a linha s é dividida em valores pelo separador ";"
                //every array position have a one peace
                string[] line = s.Split(';');
                {                    
                    Carta card = new Carta 
                    (
                        int.Parse(line[0]), //valor da carta
                        int.Parse(line[1]), //owner da carta
                        line[2] //naipe da carta
                    );
                    cards.Add(card); //adiciona a carta na lista cards
        	    }
                
            }
            return cards; //retorna a lista de cartas
        
        }
    }
}
