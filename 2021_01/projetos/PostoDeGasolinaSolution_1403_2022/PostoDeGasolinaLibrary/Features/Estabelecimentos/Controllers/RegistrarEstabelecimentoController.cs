using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Implementations;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.Repositories.Implementations;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.UseCases;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Controllers
{
    public class RegistrarEstabelecimentoController
    {
        public void callable(EstabelecimentoEntity estabelecimentoEntity)
        {
            new RegistrarEstabelecimentoUseCase(
                new RegistrarEstabelecimentoRepositoryImplementation
                (new RegistrarEstabelecimentoDSInFileImplementation())
                ).callable(estabelecimentoEntity);
        }
    }
}
