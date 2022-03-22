// See https://aka.ms/new-console-template for more information
using PostoDeGasolinaLibrary.Estabelecimentos.Controllers;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;

var _controller = new RegistrarEstabelecimentoController();
await
    _controller.callable(new EstabelecimentoEntity("Medianeira"));
//await
//    _controller.callable(new EstabelecimentoEntity("Posto de Medianeira"));
//new RegistrarEstabelecimentoController().
//    callable(new EstabelecimentoEntity("Posto Medianeira"));
//new RegistrarEstabelecimentoController().
//    callable(new EstabelecimentoEntity("Posto Matelândia"));