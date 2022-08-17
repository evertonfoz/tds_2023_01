using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Domain.Repositores.Contracts
{
    internal interface IRegistrarEstabelecimentoRepositoryContract
    {
        public void RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity);
    }
}
