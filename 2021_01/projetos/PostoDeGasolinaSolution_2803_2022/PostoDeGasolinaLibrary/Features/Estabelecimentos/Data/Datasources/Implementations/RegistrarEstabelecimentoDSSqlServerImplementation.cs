using PostoDeCombustivelCore.Errors.Exceptions;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Contracts;
using PostoDeGasolinaLibrary.Estabelecimentos.Data.Mocks;
using PostoDeGasolinaLibrary.Estabelecimentos.Domain.Entities;
using System.Data.SqlClient;

namespace PostoDeGasolinaLibrary.Estabelecimentos.Data.DataSources.Implementations
{
    public class RegistrarEstabelecimentoDSSqlServerImplementation : IRegistrarEstabelecimentoDSContract
    {
        const string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Everton\Documents\GitHub\tds_2022_1\projetos\PostoDeGasolinaSolution_2103_2022\PostoDeGasolinaDatabase\App_Data\PostoDeGasolina.mdf;Integrated Security = True";

        public async Task<bool> RegistrarEstabelecimento(EstabelecimentoEntity estabelecimentoEntity)
        {
            SqlConnection? connection = null;
            try
            {
                //string insertSQL = "INSERT INTO Estabelecimentos (EstabelecimentoID, Nome) VALUES (@EstabelecimentoID, @Nome)";
                string insertSQL = "INSERT INTO Estabelecimentos (EstabelecimentoID, Nome) VALUES ('" + estabelecimentoEntity.EstabelecimentoID + "', '" + estabelecimentoEntity.Nome + "')";
                connection = new SqlConnection(_connectionString);
                SqlCommand command = new();

                command.CommandText = insertSQL;
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                
            } catch (SqlException ex)
            {
                throw new DataAccessException($"Erro no acesso a dados: {ex.Message}");
            } finally
            {
                connection?.Close();
            }
            return true;
        }
    }
}