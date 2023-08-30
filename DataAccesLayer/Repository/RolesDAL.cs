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
    public class RolesDAL : IRolesDAL
    {
        #region EKLEME
        public void add(Roles t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into RolesDAL values(@title,@description,@status)";

            command.Parameters.AddWithValue("@title", t.title);
            command.Parameters.AddWithValue("@description", t.description);
            command.Parameters.AddWithValue("@status", t.status);


            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(Roles t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Roles WHERE ID = @RolesID";
            command.Parameters.AddWithValue("@RolesID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETIR
        public Roles GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            Roles roles = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Roles WHERE ID = @RolesID";
                command.Parameters.AddWithValue("@RolesID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    roles = new Roles();
                    roles.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    roles.title = reader.GetString(reader.GetOrdinal("title"));
                    roles.description = reader.GetString(reader.GetOrdinal("description"));
                    roles.status = reader.GetBoolean(reader.GetOrdinal("status"));


                }

                reader.Close();
                connection.Close();
            }

            return roles;
        }
        #endregion

        #region LİSTELE
        public List<Roles> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Roles> Roles = new List<Roles>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Roles";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var role = new Roles();
                role.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                role.title = reader.GetString(reader.GetOrdinal("title"));
                role.description = reader.GetString(reader.GetOrdinal("description"));
                role.status = reader.GetBoolean(reader.GetOrdinal("status"));

                Roles.Add(role);
            }
            reader.Close();
            connection.Close();


            return Roles;
        }
        #endregion

        #region GÜNCELLE
        public void update(Roles t)
        {
             var connection = new DbConnectionHelper().Connection;

    using (SqlCommand command = new SqlCommand())
    {
        command.CommandType = System.Data.CommandType.Text;
        command.Connection = connection;
        command.CommandText = @"
            UPDATE Roles 
            SET title = @Title, 
                description = @Description, 
                status = @Status 
            WHERE ID = @RolesID";
        
        command.Parameters.AddWithValue("@Title", t.title);
        command.Parameters.AddWithValue("@Description", t.description);
        command.Parameters.AddWithValue("@Status", t.status);
        command.Parameters.AddWithValue("@RolesID", t.ID);

        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
        }
        #endregion
    }
}
