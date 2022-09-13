using Aula_UmParaMuitos.Modelos;

var toyota = new Marca()
{
    MarcaID = 1,
    Nome = "Toyota"
};

try
{
	new Modelo(1, "Corolla", toyota);
	new Modelo(2, "Yaris", toyota);
	new Modelo(1, "Corolla", toyota);
	new Modelo(2, "Yaris", toyota);

}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}

//corolla.Marca = toyota;
//toyota.Modelos.Add(corolla);
//toyota.Modelos.Add(Yaris);

//Console.WriteLine(corolla.Marca.Nome);

foreach (var modelo in toyota.Modelos)
{
    Console.WriteLine(modelo.Value.Nome);
}


