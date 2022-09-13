namespace Aula_UmParaMuitos.Modelos
{
    internal class Modelo
    {
        public int ModeloID { get; set; }
        public string Nome { get; set; }
        private Marca _marca;

        public Modelo(int modeloID, string nome, Marca marca)
        {
            ModeloID = modeloID;
            Nome = nome;
            Marca = marca;
        }

        public Marca Marca
        {
            get { return _marca; }
            set { 
                _marca = value;
                _marca.RegistrarModelo(this);
            }
        }

        //public override bool Equals(object? obj)
        //{
        //    Modelo? objeto = obj as Modelo;
            

        //    return objeto?.ModeloID == ModeloID;
        //}

    }
}
