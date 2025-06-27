using System.Xml.Serialization;

namespace CSharpCollections
{
    public class Arrays
    {
        public static void main()
        {
            Console.WriteLine("Arrays...");
            var alunos = new string[] { "Joao", "Lucas", "Francisco", "Gustavo", "Gustavo" };
            var numeros = new string[3] { "1", "2", "3" };

            imprimir(alunos);
            imprimir(numeros);

            Console.WriteLine("Operação com Arrays");
            // Buscando a loc do item dentro do array
            Console.WriteLine(Array.IndexOf(alunos, "Ana"));
            // Altera a ordem do array
            Array.Reverse(alunos);
            imprimir(alunos);

            // Burlando e redimensionando o Array - Porém ele copia o array atual e cria outro com o novo tamanho
            Array.Resize(ref alunos, 10);

            // Copiando arrays
            // var alunosCopia = new string[2];
            // Array.Copy(alunos, alunosCopia, alunos.Length);
            // imprimir(alunosCopia);

            // Ordenacao
            Array.Sort(alunos);
            imprimir(alunos);

        }

        private static void imprimir(string[] array)
        {
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}