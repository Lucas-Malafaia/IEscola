namespace IEscola.Domain.Entities
{
    public class Disciplina : EntityBase
    {
        public Disciplina(int id, string nome, string descricao) 
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}
