using PostoDeCombustivelCore.Errors.Exceptions;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.Mocks;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using System.Data.SqlClient;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Implementations
{
    public class RegistrarEstabelecimentoDSSqlServerImplementation : IRegistrarEstabelecimentoDSContract
    {
        const string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Everton\Documents\GitHub\tds_2022_1\projetos\PostoDeGasolinaSolution_1703_2022\PostoDeGasolinaDatabase\App_Data\PostoDeGasolina.mdf;Integrated Security = True";

        public async Task<bool> RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity)
        {
            try
            {
                //string insertSQL = "INSERT INTO Estabelecimentos (EstabelecimentoID, Nome) VALUES (@EstabelecimentoID, @Nome)";
                string insertSQL = "INSERT INTO Estabelecimentos (EstabelecimentoID, Nome) VALUES ('" + estabelecimentoEntity.EstabelecimentoID + "', '" + estabelecimentoEntity.Nome + "')";
                SqlConnection connection = new SqlConnection(_connectionString);
                SqlCommand command = new SqlCommand();

                command.CommandText = insertSQL;
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            } catch (SqlException ex)
            {
                throw new DataAccessException($"Erro no acesso a dados: {ex.Message}");
            }
            return true;
        }
    }
}