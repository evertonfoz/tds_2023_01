using PostoDeCombustivelCore.Errors.Either;
using PostoDeCombustivelCore.Errors.Exceptions;
using PostoDeCombustivelCore.Errors.Failures;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Repositores.Contracts;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.Repositories.Implementations
{
    public class RegistrarEstabelecimentoRepositorySQLServerImplementation : IRegistrarEstabelecimentoRepositoryContract
    {
        private IRegistrarEstabelecimentoDSContract _dataSource;

        public RegistrarEstabelecimentoRepositorySQLServerImplementation(IRegistrarEstabelecimentoDSContract dataSource)
        {
            _dataSource = dataSource;
        }
        public async Task<Either<Failure, bool>>  RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity)
        {
            Either<Failure, bool> _eitherResult;
            try
            {
                bool result =  await _dataSource.RegistrarEstabelecimento(estabelecimentoEntity);
                _eitherResult = new Either<Failure, bool>(result); 
            } catch (DataAccessException)
            {
                _eitherResult = new Either<Failure, bool>(new DataAccessFailure());
            }
            return _eitherResult;
        }
    }
}
