using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.Mocks;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Implementations
{
    internal class RegistrarEstabelecimentoDSInFileImplementation : IRegistrarEstabelecimentoDSContract
    {
        public async Task RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity)
        {
            string? entidade = estabelecimentoEntity.ToString();

            await File.WriteAllTextAsync("C:\\Temp\\WriteLines.txt", entidade);
        }
    }
}
