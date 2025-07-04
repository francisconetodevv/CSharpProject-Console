namespace CSharpCollections
{
    public class ListasLigadas
    {
        public static void main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Aulas Listas Ligadas");
            Console.WriteLine("-------------------------");

            // 1 <-> 2 <-> 3 <-> 4 <-> 5
            var listaLigada = new LinkedList<string>();

            // [Primeira posição] -> []
            var NodeUm = listaLigada.AddFirst("Primeira posição");

            // [Primeira posição] <-> [Segunda posição] -> []
            var NodeDois = listaLigada.AddAfter(NodeUm, "Segunda posição");

            // [Primeira posição] <-> [Terceira posição] <-> [Segunda posição] -> []
            var NodeTres = listaLigada.AddBefore(NodeDois, "Terceira posição");

            // [Primeira posição] <-> [Terceira posição] <-> [Segunda posição] <-> [Quarta posição] -> []
            var NodeQuatro = listaLigada.AddLast("Quarta posição");

            imprimir(listaLigada);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Removendo valores da lista ligada");

            listaLigada.RemoveFirst();
            imprimir(listaLigada);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Se o elemento existe na lista");

            Console.WriteLine(listaLigada.Contains("Segunda posição"));
            Console.WriteLine(listaLigada.Find("Segunda posição"));

        }

        private static void imprimir(LinkedList<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}