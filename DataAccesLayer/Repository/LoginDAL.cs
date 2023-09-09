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
    public class LoginDAL : ILoginDAL
    {
        #region EKLEME
        public void add(Login t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Login values(@userName,@password,@status)";

            command.Parameters.AddWithValue("@userName", t.userName);
            command.Parameters.AddWithValue("@password", t.password);
            command.Parameters.AddWithValue("@status", t.status);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(Login t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Login WHERE userID = @JobApplicationsID";
            command.Parameters.AddWithValue("@LoginID", t.userID);
        }
        #endregion

        #region ID'YEGOREGETİR
        public Login GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            Login login = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Login WHERE ID = @LoginID";
                command.Parameters.AddWithValue("@LoginID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    login = new Login();
                    login.userID = reader.GetInt32(reader.GetOrdinal("userID"));
                    login.userName = reader.GetString(reader.GetOrdinal("userName"));
                    login.password = reader.GetString(reader.GetOrdinal("password"));
                    login.status = reader.GetBoolean(reader.GetOrdinal("status"));
                }

                reader.Close();
                connection.Close();
            }

            return login;
        }
        #endregion

        #region LİSTELE
        public List<Login> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Login> Login = new List<Login>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Login";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var login = new Login();
                login.userID = reader.GetInt32(reader.GetOrdinal("userID"));
                login.userName = reader.GetString(reader.GetOrdinal("userName"));
                login.password = reader.GetString(reader.GetOrdinal("password"));
                login.status = reader.GetBoolean(reader.GetOrdinal("status"));


                Login.Add(login);
            }
            reader.Close();
            connection.Close();


            return Login;
        }
        #endregion

        #region GÜNCELLE
        public void update(Login t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"UPDATE Login SET userName = @UserName, password = @Password, status = @Status WHERE userID = @UserID";

                command.Parameters.AddWithValue("@UserName", t.userName);
                command.Parameters.AddWithValue("@Password", t.password);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@UserID", t.userID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion


        #region AKTİF ŞİRKETTE KULLANICI ADI VE PAROLAYA GÖRE GETİR
        public Login GetByUserNameAndPasswordActiveCompany(string userName, string password)
        {
            var connection = new DbConnectionHelper().Connection;
            Login login = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"Select l.UserID   from [KolayIK].[dbo].[Login] as l
                                      left join [KolayIK].[dbo].[User] as u
                                      on l.UserID = u.ID
                                      left join [KolayIK].[dbo].[Companies] as c
                                      on u.companyID  = c.ID
                                      left join [KolayIK].[dbo].[Roles] as r
                                      on r.ID = u.roleID
                                      where l.userName=@userName and l.password=@password and c.status =1 and u.status=1";
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    login = new Login();
                    login.userID = reader.GetInt32(reader.GetOrdinal("userID"));
                }

                reader.Close();
                connection.Close();
            }
            return login;
        }

        #endregion
    }
}
