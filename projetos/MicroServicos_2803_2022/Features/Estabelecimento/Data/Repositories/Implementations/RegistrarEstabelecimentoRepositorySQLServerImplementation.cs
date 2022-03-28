using PostoDeGasolinaLibrary.Core.Errors.Either;
using PostoDeGasolinaLibrary.Core.Errors.Exceptions;
using PostoDeGasolinaLibrary.Core.Errors.Failures;
using PostoDeGasolinaLibrary.Features.Estabelecimentos.Data.DataSources;
using PostoDeGasolinaLibrary.Features.Estabelecimentos.Data.Models;
using PostoDeGasolinaLibrary.Features.Estabelecimentos.Domain.Repositories;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.Repositories.Implementations
{
    public class RegistrarEstabelecimentoRepositorySQLServerImplementation : IRegistrarEstabelecimentoRepositoryContract
    {
        private IRegistrarEstabelecimentoDSContract _dataSource;

        public RegistrarEstabelecimentoRepositorySQLServerImplementation(IRegistrarEstabelecimentoDSContract dataSource)
        {
            _dataSource = dataSource;
        }
        public async Task<Either<Failure, bool>>  RegistrarEstabelecimento(EstabelecimentoModel estabelecimentoModel)
        {
            Either<Failure, bool> _eitherResult;
            try
            {
                bool result =  await _dataSource.RegistrarEstabelecimento(estabelecimentoModel);
                _eitherResult = new Either<Failure, bool>(result); 
            } catch (DataAccessException)
            {
                _eitherResult = new Either<Failure, bool>(new DataAccessFailure());
            }
            return _eitherResult;
        }
    }
}
