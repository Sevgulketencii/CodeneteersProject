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
    public class RolePermissionsDAL : IRolePermissionsDAL
    {
        #region EKLEME
        public void add(RolePermissions t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into RolePermissions values(@roleID,@permissionID,@status)";

            command.Parameters.AddWithValue("@roleID", t.roleID);
            command.Parameters.AddWithValue("@permissionID", t.permissionID);
            command.Parameters.AddWithValue("@status", t.status);
 

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion 

        #region SİLME
        public void delete(RolePermissions t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM RolePermissions WHERE ID = @RolePermissionsID";
            command.Parameters.AddWithValue("@RolePermissionsID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETIR
        public RolePermissions GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            RolePermissions rolePermissions = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM RolePermissions WHERE ID = @RolePermissionsID";
                command.Parameters.AddWithValue("@RolePermissionsID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    rolePermissions = new RolePermissions();
                    rolePermissions.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    rolePermissions.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                    rolePermissions.permissionID = reader.GetInt32(reader.GetOrdinal("permissionID"));
                    rolePermissions.status = reader.GetBoolean(reader.GetOrdinal("status"));


                }

                reader.Close();
                connection.Close();
            }

            return rolePermissions;
        }
        #endregion

        #region LİSTELE
        public List<RolePermissions> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<RolePermissions> RolePermissions = new List<RolePermissions>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from RolePermissions";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var rolePermissions = new RolePermissions();
                rolePermissions.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                rolePermissions.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                rolePermissions.permissionID = reader.GetInt32(reader.GetOrdinal("permissionID"));
                rolePermissions.status = reader.GetBoolean(reader.GetOrdinal("status"));

                RolePermissions.Add(rolePermissions);
            }
            reader.Close();
            connection.Close();


            return RolePermissions;
        }
        #endregion

        #region GÜNCELLE
        public void update(RolePermissions t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"
            UPDATE RolePermissions 
            SET roleID = @RoleID, 
                permissionID = @PermissionID, 
                status = @Status 
            WHERE ID = @RolePermissionsID";

                command.Parameters.AddWithValue("@RoleID", t.roleID);
                command.Parameters.AddWithValue("@PermissionID", t.permissionID);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@RolePermissionsID", t.ID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
