namespace Aula_UmParaMuitos.Modelos
{
    internal class Marca
    {
        public int MarcaID { get; set; }
        public string Nome { get; set; }
        public Dictionary<int, Modelo> Modelos { get; private set; } = new();

        public void RegistrarModelo(Modelo modelo)
        {
            Modelos.Add(modelo.ModeloID, modelo);
            //if (!Modelos.Contains(modelo)) {
            //    Modelos.Add(modelo);
            //} else
            //{
            //    throw new Exception($"{modelo.Nome} já está registrado");
            //}
        }
    }
}
