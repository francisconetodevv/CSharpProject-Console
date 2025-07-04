namespace CSharpCollections
{
    public class Pilhas
    {
        public static void main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Aulas sobre pilhas");
            Console.WriteLine("-------------------------");

            var pilha = new Stack<string>();

            pilha.Push("Livro 1");
            pilha.Push("Livro 2");
            pilha.Push("Livro 3");
            pilha.Push("Livro 4");

            imprimir(pilha);

            // Remover o primeiro elemento da fila, logo o último adicionado
            pilha.Pop();
        }

        private static void imprimir(Stack<string> pilha)
        {
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}