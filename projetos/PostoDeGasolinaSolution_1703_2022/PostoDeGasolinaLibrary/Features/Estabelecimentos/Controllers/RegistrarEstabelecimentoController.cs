using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Implementations;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.Repositories.Implementations;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.UseCases;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Controllers
{
    public class RegistrarEstabelecimentoController
    {
        public async Task callable(EstabelecimentoEntity estabelecimentoEntity)
        {
            var _useCase = new RegistrarEstabelecimentoUseCase(
                new RegistrarEstabelecimentoRepositorySQLServerImplementation
                (new RegistrarEstabelecimentoDSSqlServerImplementation())
                );

            await _useCase.callable(estabelecimentoEntity);
        }
    }
}
