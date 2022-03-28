using PostoDeGasolinaLibrary.Core.Errors.Either;
using PostoDeGasolinaLibrary.Core.Errors.Failures;
using PostoDeGasolinaLibrary.Features.Estabelecimentos.Data.Models;

namespace PostoDeGasolinaLibrary.Features.Estabelecimentos.Domain.Repositories
{
    public interface IRegistrarEstabelecimentoRepositoryContract
    {
        public Task<Either<Failure, bool>> RegistrarEstabelecimento(EstabelecimentoModel estabelecimentoModel);
    }
}
