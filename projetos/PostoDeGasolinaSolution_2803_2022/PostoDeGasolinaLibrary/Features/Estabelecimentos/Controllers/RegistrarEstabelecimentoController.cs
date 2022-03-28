using PostoDeCombustivelCore.Errors.Either;
using PostoDeCombustivelCore.Errors.Failures;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Implementations;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.Repositories.Implementations;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.UseCases;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Controllers
{
    public class RegistrarEstabelecimentoController
    {
        public async Task<Either<Failure, bool>> callable(EstabelecimentoEntity estabelecimentoEntity)
        {
            var _useCase = new RegistrarEstabelecimentoUseCase(
                new RegistrarEstabelecimentoRepositorySQLServerImplementation
                (new RegistrarEstabelecimentoDSSqlServerImplementation())
                );

            return await _useCase.callable(estabelecimentoEntity);
        }
    }
}
