using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Aluno
    {
        public string Nome;
        public string Matricula;
        public string Telefone;

        public override string ToString()
        {
            return $"{Matricula} | {Nome} | {Telefone}";
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno() { Nome = "Jose", Matricula = "12345", Telefone = "88888888"};
            Aluno aluno2 = new Aluno() { Nome = "Joao", Matricula = "678910", Telefone = "99999999" };
            Aluno aluno3 = new Aluno() { Nome = "Francisco", Matricula = "129587", Telefone = "77777777" };
            
            Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>();
            
            alunos.Add(1, aluno1);
            alunos.Add(2, aluno2);
            alunos.Add(3, aluno3);

            if (alunos.TryGetValue(2, out Aluno aluno))
            {
                Console.WriteLine(aluno);
            }

            foreach (KeyValuePair<int, Aluno> a in alunos)
            {
                Console.WriteLine($"{a.Key}: {a.Value}");   
            }
        }
    }
}