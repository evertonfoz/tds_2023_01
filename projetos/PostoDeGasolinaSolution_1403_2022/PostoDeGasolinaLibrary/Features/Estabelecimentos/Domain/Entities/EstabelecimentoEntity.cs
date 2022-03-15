namespace PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities
{
    public class EstabelecimentoEntity
    {
        public String EstabelecimentoID { get; init; }
        public String Nome { get; init; }

        public EstabelecimentoEntity(string nome)
        {
            EstabelecimentoID = Guid.NewGuid().ToString();
            Nome = nome;
        }

        public override string ToString()
        {
            return $"ID: {EstabelecimentoID}: {Nome}";
        }
    }
}