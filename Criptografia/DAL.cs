using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Criptografia
{
    public class DalHelper : IDisposable
    {
        private static SqlConnection sqlConnection;
        private static string sqlConnectionString;

        public DalHelper()
        { }

        private static string DbConnectionString()
        {
            sqlConnectionString = ConfigurationManager.ConnectionStrings["LicencaModelos"].ConnectionString;
            return sqlConnectionString;
        }

        private static SqlConnection DbConnection()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["LicencaModelos"].ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public static DataTable GetClientes()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM cliente WHERE ativo=1";
                    da = new SqlDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static DataTable GetAlunoTabela(int id)
        //{
        //    SqlDataAdapter da = null;
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        using (var cmd = DbConnection().CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM Alunos Where AlunoId=" + id;
        //            da = new SqlDataAdapter(cmd.CommandText, DbConnection());
        //            da.Fill(dt);
        //            return dt;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public static Licenca GetLicenca(int id)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Licenca licenca = new Licenca();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM licenca WHERE idCliente=" + id;
                    da = new SqlDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        licenca.Chave = dt.Rows[0]["chave"].ToString();
                        licenca.Chave1 = dt.Rows[0]["chave1"].ToString();
                        licenca.Chave2 = dt.Rows[0]["chave2"].ToString();
                        licenca.IdCliente = (int)dt.Rows[0]["idCliente"];
                        licenca.IdLicenca = (int)dt.Rows[0]["idLicenca"];
                    }
                    return licenca;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(Licenca licenca)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO licenca (chave, chave1, chave2, idCliente) values (@chave, @chave1, @chave2, @idCliente)";
                    cmd.Parameters.AddWithValue("@chave", licenca.Chave );
                    cmd.Parameters.AddWithValue("@chave1", licenca.Chave1);
                    cmd.Parameters.AddWithValue("@chave2", licenca.Chave2);
                    cmd.Parameters.AddWithValue("@idCliente", licenca.IdCliente);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(Licenca licenca)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    if (licenca != null)
                    {
                        cmd.CommandText = "UPDATE licenca SET chave=@Chave, chave1=@Chave1, chave2=@Chave2, idCliente=@IdCliente WHERE idLicenca = @IdLicenca";
                        cmd.Parameters.AddWithValue("@Chave", licenca.Chave);
                        cmd.Parameters.AddWithValue("@Chave1", licenca.Chave1);
                        cmd.Parameters.AddWithValue("@Chave2", licenca.Chave2);
                        cmd.Parameters.AddWithValue("@IdCliente", licenca.IdCliente);
                        cmd.Parameters.AddWithValue("@IdLicenca", licenca.IdLicenca);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static void Delete(int Id)
        //{
        //    try
        //    {
        //        using (var cmd = DbConnection().CreateCommand())
        //        {
        //            cmd.CommandText = "DELETE FROM Alunos Where AlunoId=@Id";
        //            cmd.Parameters.AddWithValue("@Id", Id);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}