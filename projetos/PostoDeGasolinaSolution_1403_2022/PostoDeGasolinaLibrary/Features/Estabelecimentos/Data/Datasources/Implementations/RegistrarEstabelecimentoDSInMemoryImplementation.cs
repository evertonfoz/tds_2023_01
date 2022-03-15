using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.Mocks;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Implementations
{
    internal class RegistrarEstabelecimentoDSInMemoryImplementation : IRegistrarEstabelecimentoDSContract
    {
        public async Task RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity)
        {
            InMemoryMock.EstabelecimentosList.Add(estabelecimentoEntity);
            foreach (var estabelecimento in InMemoryMock.EstabelecimentosList)
            {
                Console.WriteLine(estabelecimento);
            }
        }
    }
}
