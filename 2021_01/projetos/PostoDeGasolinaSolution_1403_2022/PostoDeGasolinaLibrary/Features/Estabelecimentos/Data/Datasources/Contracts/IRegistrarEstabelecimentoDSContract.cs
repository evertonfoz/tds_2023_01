using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts
{
    internal interface IRegistrarEstabelecimentoDSContract
    {
        public Task RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity);
    }
}
