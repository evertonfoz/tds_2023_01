using PostoDeCombustivelCore.Errors.Either;
using PostoDeCombustivelCore.Errors.Failures;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Domain.Repositores.Contracts
{
    public interface IRegistrarEstabelecimentoRepositoryContract
    {
        public Task<Either<Failure, bool>> RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity);
    }
}
