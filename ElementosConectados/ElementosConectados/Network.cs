using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosConectados
{
	class Network
	{
		private int[,] matrizAdj; //matriz de adjacências (Conexões)
		private int[] visit; // Vetor de elementos visitados

		public Network(int numElements)
		{
			//Cria a instância da matriz de adjacência e o vetor de visitas com o número de elementos digitado pelo usuário
			matrizAdj = new int[numElements, numElements];
			visit = new int[numElements];
		}

		//Retorna lista de elementos para a montagem dos combo box
		public List<int> getElements()
		{
			List<int> elements = new List<int>();
			for (int i = 0; i < matrizAdj.GetLength(1); i++)
			{
				elements.Add(i + 1);
			}
			return elements;
		}


		//Método que realiza a conexão de dois elementos
		public void Connect(int element1, int element2)
		{
			//Chama o métodos de validação dos elementos
			CheckElements(element1,element2);

			//Verificar se já existe a conexão que está sendo cadastrada, se sim lança exceção
			if (Query(element1, element2, true))
			{
				throw new Exception(String.Format("A conexão entre os elementos {0} e {1} já existe!", element1, element2));
			}

			//Realiza a conexão entre os dois elementos armazenando na matriz de adjacência em ambos os sentidos
			if (element1 <= matrizAdj.Length &&
				element2 <= matrizAdj.Length)
			{
				matrizAdj[element1 - 1, element2 - 1] = 1;
				matrizAdj[element2 - 1, element1 - 1] = 1;
			}
		}

		//Método que verifica se dois elementos estão conectados direta ou indiretamente
		public bool Query(int element1, int element2, bool onlyDirect = false)
		{
			//Chama o método de validação de elementos
			CheckElements(element1, element2);

			//Verifica se os elementos estão conectados diretamente
			if (matrizAdj[element1 - 1, element2 - 1] == 1)
			{
				return true;
			}

			//Verifica se a consulta é somente por conexões diretas
			if (onlyDirect)
			{
				return false;
			}
			else
			{

				//Seta todos os elementos como não visitados no vertor de visitas
				// 0 - não visitado
				// 1 - visitado
				for (int v = 0; v < matrizAdj.GetLength(1); ++v)
				{
					visit[v] = 0;
				}

				// Starta a busca em profundidade partindo do elemento 1
				RecursiveSearch(matrizAdj, element1 - 1);

				//Verifica se não foi possível visitar o elemento 2
				if (visit[element2 - 1] == 0)
				{
					return false;
				}				
			}

			return true;
		}

		//Método de busca recursiva em profundidade
		public void RecursiveSearch(int[,] G, int v)
		{
			//Seta o elemento como visitado no vetor de visitas
			visit[v] = 1;
			for (int w = 0; w < G.GetLength(1); ++w)
			{
				if (G[v, w] == 1 && visit[w] == 0)
				{
					//Chama o método de busca novamente
					RecursiveSearch(G, w);
				}
			}
		}

		//Método de validação dos elementos
		private void CheckElements(int element1, int element2)
		{
			//Verificar se os elementos são iguais, se sim lança exceção
			if (element1 == element2)
			{
				throw new Exception("Os elementos são iguais!\nFavor selecionar elementos diferentes.");
			}

			//Verificar se os elementos são menores ou iguais a zero, se sim lança exceção
			if (element1 <= 0 ||
				element2 <= 0)
			{
				throw new Exception("Os elementos devem estar na faixa de 1 a " + matrizAdj.Length);
			}
		}

	}
}
