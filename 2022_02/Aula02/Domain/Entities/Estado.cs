namespace Aula02.Domain.Entities
{
    public class EstadoEntity
    {
        public int? EstadoID { get; private set; }
        public string UF { get; private set; }
        public string Nome { get; private set; }

        public EstadoEntity(string uf, string nome, int? estadoID=null)
        {
            UF = uf;
            Nome = nome;
            EstadoID = estadoID;
        }

        public void Update(string uf, string nome)
        {
            UF = uf;
            Nome = nome;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(EstadoID);
        }

        public override int GetHashCode()
        {
            return EstadoID.GetHashCode();
        }

        public override string ToString()
        {
            return $"[{UF}] - [{Nome}]";
        }
    }
}
