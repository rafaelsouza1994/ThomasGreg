using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Rafael
{
    public class DalHelper
    {
        private static SQLiteConnection sqliteConnection;
        public DalHelper()
        { }
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=c:\\temp\\acme.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public static void CriarBancoSQLite()
        {
            if (File.Exists("@c:\temp\acme.sqlite"))
            {
                try
                {
                    SQLiteConnection.CreateFile(@"c:\temp\acme.sqlite");
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void CriarTabelaSQlite()
        {
            if (!File.Exists("acme.sqlite"))
            {
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(" +
                            " ID_VOO Integer PRIMARY KEY AUTOINCREMENT," +
                            " DATA_VOO Datetime NOT NULL," +
                            " CUSTO numeric(10,2) NOT NULL," +
                            " DISTANCIA Int NOT NULL," +
                            " CAPTURA Char(1) NOT NULL," +
                            " NIVEL_DOR Int NOT NULL)";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static DataTable GetVoos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TB_VOO";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetVoo(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TB_VOO Where ID_VOO=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Add(Voo voo)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TB_VOO(DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) values (@Data_voo, @Custo, @Distancia, @Captura, @Nivel_dor)";
                    cmd.Parameters.AddWithValue("@data_voo", voo.Data);
                    cmd.Parameters.AddWithValue("@custo", voo.Custo);
                    cmd.Parameters.AddWithValue("@distancia", voo.Distancia);
                    cmd.Parameters.AddWithValue("@captura", voo.Captura);
                    cmd.Parameters.AddWithValue("@nivel_dor", voo.Dor);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Update(Voo voo)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                    if (voo.Id != null)
                    {
                        {
                            cmd.CommandText = "UPDATE TB_VOO SET id_voo=@Id, data_voo=@Data, Custo=@Custo, Distancia=@Distancia, captura=@Captura, nivel_dor=@Dor WHERE Id_voo=@Id";
                            cmd.Parameters.AddWithValue("@id_voo", voo.Id);
                            cmd.Parameters.AddWithValue("@data_voo", voo.Data);
                            cmd.Parameters.AddWithValue("@custo", voo.Custo);
                            cmd.Parameters.AddWithValue("@distancia", voo.Distancia);
                            cmd.Parameters.AddWithValue("@captura", voo.Captura);
                            cmd.Parameters.AddWithValue("@nivel_dor", voo.Dor);
                            cmd.ExecuteNonQuery();
                        }
                    };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM TB_VOO Where ID_VOO=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }







































    }
}