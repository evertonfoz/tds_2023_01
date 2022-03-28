using PostoDeGasolinaLibrary.Features.Estabelecimentos.Domain.Entities;

namespace PostoDeGasolinaLibrary.Features.Estabelecimentos.Data.Models
{
    public class EstabelecimentoModel : EstabelecimentoEntity
    {
        public string IDEstabelecimento
        {
            get { return base.EstabelecimentoID; }
        }
        public string NomeEstabelecimenti
        {
            get { return base.Nome; }
        }
        public EstabelecimentoModel(string nome) : base(nome)
        {
            Nome = nome;
        }
    }
}