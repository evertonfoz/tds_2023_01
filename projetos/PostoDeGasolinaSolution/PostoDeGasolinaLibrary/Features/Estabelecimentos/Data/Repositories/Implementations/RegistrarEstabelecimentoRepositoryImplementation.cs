using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Repositores.Contracts;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.Repositories.Implementations
{
    internal class RegistrarEstabelecimentoRepositoryImplementation : IRegistrarEstabelecimentoRepositoryContract
    {
        private IRegistrarEstabelecimentoDSContract _dataSource;

        public RegistrarEstabelecimentoRepositoryImplementation(IRegistrarEstabelecimentoDSContract dataSource)
        {
            _dataSource = dataSource;
        }
        public void RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity)
        {
            _dataSource.RegistrarEstabelecimento(estabelecimentoEntity);
        }
    }
}
