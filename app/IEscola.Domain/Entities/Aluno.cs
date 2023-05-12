using System;

namespace IEscola.Domain.Entities
{
    public class Aluno : EntityBase
    {
        public Aluno(int id, string nome, DateTime dataNascimento, int numeroMatricula, char sexo)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            NumeroMatricula = numeroMatricula;
            Sexo = sexo;
        }

        public string Nome { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public int NumeroMatricula { get; set; }
        public string Tratamento { get; set; }

    }
}
