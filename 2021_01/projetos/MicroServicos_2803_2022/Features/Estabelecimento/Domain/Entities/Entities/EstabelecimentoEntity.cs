namespace PostoDeGasolinaLibrary.Features.Estabelecimentos.Domain.Entities
{
    public class EstabelecimentoEntity
    {
        #region Properties
        public String EstabelecimentoID { get; init; }
        public String Nome { get; init; }
        #endregion

        #region Constructors
        public EstabelecimentoEntity(string nome)
        {
            EstabelecimentoID = Guid.NewGuid().ToString();
            Nome = nome;
        }
        #endregion

        #region Overrides
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return EstabelecimentoID.Equals(
                ((EstabelecimentoEntity)obj).EstabelecimentoID);
        }

        public override int GetHashCode()
        {
            return EstabelecimentoID.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID: {EstabelecimentoID}: {Nome}";
        }
        #endregion
    }
}