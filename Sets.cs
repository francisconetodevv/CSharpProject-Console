namespace CSharpCollections
{
    public class Sets
    {
        public static void main()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Aula sobre coleções");
            Console.WriteLine("-------------------------");


            // Criando o sets - conjuntos 
            // var alunos = new HashSet<string>();
            // alunos.Add("Claysson");
            // alunos.Add("Sarah");
            // alunos.Add("Neto");

            // imprimir(alunos);

            // Console.WriteLine(alunos.First(aluno => aluno.StartsWith("S")));

            // Fazendo testes com HashSet
            var alunos = new HashSet<Aluno>();
            alunos.Add(new Aluno("Clayson", "Lima"));
            alunos.Add(new Aluno("Helton", "Fonseca"));
            alunos.Add(new Aluno("Clayson", "Lima"));

            imprimir(alunos);

            // Demonstrando o HashCode de cada Coleção
            Console.WriteLine(new Aluno("Neto", "José").GetHashCode());
            Console.WriteLine(new Aluno("Luk", "Adrian").GetHashCode());
            Console.WriteLine(new Aluno("Neto", "José").GetHashCode());

        }

        private static void imprimir(HashSet<Aluno> sets)
        {
            foreach (var i in sets)
            {
                Console.WriteLine(i);
            }
        }
    }

    // Implementação manual para demonstração do HashCode
    public class Aluno
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }


        public Aluno(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }

        public override bool Equals(object? obj)
        {
            var aluno = obj as Aluno;
            if (aluno is null)
            {
                return false;
            }
            return $"{Nome} {Sobrenome}".Equals($"{aluno.Nome} {aluno.Sobrenome}");
        }

        public override int GetHashCode()
        {
            return $"{Nome} {Sobrenome}".GetHashCode();
        }
    }
}