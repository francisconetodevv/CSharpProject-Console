namespace CSharpCollections
{
    public class Filas
    {
        public static void main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Aula filas");
            Console.WriteLine("-------------------------");

            var fila = new Queue<string>();

            // [Kako]
            fila.Enqueue("Kako");

            // [Kako] [Neto] 
            fila.Enqueue("Neto");

            // [Kako] [Neto] [José]
            fila.Enqueue("José");

            imprimir(fila);

            Console.WriteLine("-------------------------");
            Console.WriteLine("Removendo elementos");

            var primeiroASair = fila.Dequeue();
            Console.WriteLine("O primeiro a sair da fila é o primeiro que entrou, por isso não passa por parâmetro");
            imprimir(fila);
        }

        private static void imprimir(Queue<string> fila)
        {
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}