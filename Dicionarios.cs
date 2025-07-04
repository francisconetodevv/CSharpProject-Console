namespace CSharpCollections
{
    public class Dicionario
    {
        public static void main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Aula sobre dicionarios");
            Console.WriteLine("-------------------------");

            var alunos = new Dictionary<string, string>();

            // Adicionando valores ao dicionario
            alunos.Add("123", "Francisco");
            imprimir(alunos);

            // Ou adicionar assim
            alunos["542"] = "Neto";
            imprimir(alunos);

        }

        private static void imprimir(Dictionary<string, string> dicionario)
        {
            foreach (var item in dicionario)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}