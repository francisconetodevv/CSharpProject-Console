namespace CSharpCollections
{
    public class Listas
    {
        public static void main()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Aula sobre Listas...");

            // Definindo uma lista
            var aulas = new List<string>();

            imprimir(aulas);

            // Adicionando valores a lista
            aulas.Add("Matemática");
            aulas.Add("Português");
            imprimir(aulas);

            // Contando os valores dentro da lista
            Console.WriteLine(aulas.Count);

            // Capacidade da lista 
            Console.WriteLine(aulas.Capacity);

            // Verificando a existencia de aulas
            Console.WriteLine(aulas.Contains("Português"));

            // Removendo item da lista
            aulas.Remove("Matemática");
            imprimir(aulas);

            // Primeiro valor da lista e o último
            Console.WriteLine(aulas.First());
            Console.WriteLine(aulas.Last());

            Console.WriteLine("----------------------");
            Console.WriteLine("Operações com lista!");

            aulas.Add("Inglês");
            aulas.Add("Matemática");
            aulas.Add("Geografia");
            aulas.Add("História");

            Console.WriteLine(aulas.IndexOf("Geografia"));

            // Inserindo na posicao 2
            aulas.Insert(2, "Amauri");
            imprimir(aulas);

            // Removendo um item do index especifico
            aulas.RemoveAt(2);
            imprimir(aulas);

            // Encontrando valores que começam com um valor
            Console.WriteLine(aulas.Find(aulas => aulas.StartsWith("M")));


            // Copiando os valores de um range para outra variável
            Console.WriteLine("------------------------");
            var aulasDois = aulas.GetRange(3, 2);
            imprimir(aulasDois);
            

        }

        private static void imprimir(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}