using PostoDeGasolinaLibrary.Features.Estabelecimentos.Data.Models;

namespace PostoDeGasolinaLibrary.Features.Estabelecimentos.Data.DataSources
{
    public interface IRegistrarEstabelecimentoDSContract
    {
        public Task<bool> RegistrarEstabelecimento(EstabelecimentoModel estabelecimentoModel);
    }
}
