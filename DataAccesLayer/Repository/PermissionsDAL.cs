using DataAccesLayer.Abstract;
using DataAccesLayer.Helpers;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repository
{
    public class PermissionsDAL : IPermissionsDAL
    {
        #region EKLEME
        public void add(Permissions t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Permissions values(@name,@status)";

            command.Parameters.AddWithValue("@name", t.name);
            command.Parameters.AddWithValue("@status", t.status);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(Permissions t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Permissions WHERE ID = @PermissionsID";
            command.Parameters.AddWithValue("@PermissionsID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETİR  
        public Permissions GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            Permissions permissions = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Permissions WHERE ID = @PermissionsID";
                command.Parameters.AddWithValue("@PermissionsID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    permissions = new Permissions();
                    permissions.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    permissions.name = reader.GetString(reader.GetOrdinal("name"));
                    permissions.status = reader.GetBoolean(reader.GetOrdinal("status"));


                }

                reader.Close();
                connection.Close();
            }

            return permissions;
        }
        #endregion

        #region LİSTELE
        public List<Permissions> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Permissions> Permissions = new List<Permissions>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Permissions";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var permissions = new Permissions();
                permissions.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                permissions.name = reader.GetString(reader.GetOrdinal("name"));
                permissions.status = reader.GetBoolean(reader.GetOrdinal("status"));


                Permissions.Add(permissions);
            }
            reader.Close();
            connection.Close();


            return Permissions;
        }
        #endregion

        #region GÜNCELLE
        public void update(Permissions t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"UPDATE Permissions SET name = @Name, status = @Status WHERE ID = @PermissionsID";

                command.Parameters.AddWithValue("@Name", t.name);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@PermissionsID", t.ID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
