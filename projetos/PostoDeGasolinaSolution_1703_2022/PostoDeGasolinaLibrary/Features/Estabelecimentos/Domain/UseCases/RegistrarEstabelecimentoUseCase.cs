using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Repositores.Contracts;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Domain.UseCases
{
    internal class RegistrarEstabelecimentoUseCase
    {
        private IRegistrarEstabelecimentoRepositoryContract _repository;
        public RegistrarEstabelecimentoUseCase(IRegistrarEstabelecimentoRepositoryContract repository) 
        {
            _repository = repository;
        }

        public async Task callable(EstabelecimentoEntity estabelecimentoEntity)
        {
            await _repository.RegistrarEstabelecimento(estabelecimentoEntity);
        }
    }
}
