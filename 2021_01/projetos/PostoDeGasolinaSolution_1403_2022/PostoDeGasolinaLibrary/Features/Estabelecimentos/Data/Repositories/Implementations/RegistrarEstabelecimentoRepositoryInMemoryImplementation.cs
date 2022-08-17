using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Repositores.Contracts;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.Repositories.Implementations
{
    internal class RegistrarEstabelecimentoRepositoryInMemoryImplementation : IRegistrarEstabelecimentoRepositoryContract
    {
        private IRegistrarEstabelecimentoDSContract _dataSource;

        public RegistrarEstabelecimentoRepositoryInMemoryImplementation(IRegistrarEstabelecimentoDSContract dataSource)
        {
            _dataSource = dataSource;
        }
        public void RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity)
        {
            _dataSource.RegistrarEstabelecimento(estabelecimentoEntity);
        }
    }
}
