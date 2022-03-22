using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts
{
    public interface IRegistrarEstabelecimentoDSContract
    {
        public Task<bool> RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity);
    }
}
