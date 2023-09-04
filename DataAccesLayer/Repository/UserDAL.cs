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
    public class UserDAL : IUserDAL
    {
        #region EKLEME
        public void add(User t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into User values(@roleID,@name,@surname,@imageUrl,@genderID,@phoneNumber,@eMail,@civilised,@address,@companyID,@birthDate,@enrolledDate,@exitDate,@price,@status)";
            command.Parameters.AddWithValue("@roleID", t.roleID);
            command.Parameters.AddWithValue("@name", t.name);
            command.Parameters.AddWithValue("@surname", t.surname);
            command.Parameters.AddWithValue("@imageUrl", t.imageUrl);
            command.Parameters.AddWithValue("@genderID", t.genderID);
            command.Parameters.AddWithValue("@phoneNumber", t.phoneNumber);
            command.Parameters.AddWithValue("@eMail", t.eMail);
            command.Parameters.AddWithValue("@civilised", t.civilised);
            command.Parameters.AddWithValue("@companyID", t.companyID);
            command.Parameters.AddWithValue("@birthDate", t.birthDate);
            command.Parameters.AddWithValue("@enrolledDate", t.enrolledDate);
            command.Parameters.AddWithValue("@exitDate", t.exitDate);
            command.Parameters.AddWithValue("@price", t.price);
            command.Parameters.AddWithValue("@status", t.status);


            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(User t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM User WHERE ID = @UserID";
            command.Parameters.AddWithValue("@UserID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETİR
        public User GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            User user = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM [dbo].[User] WHERE ID = @UserID";
                command.Parameters.AddWithValue("@UserID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = new User();
                    user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    user.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                    user.name = reader.GetString(reader.GetOrdinal("name"));
                    user.surname = reader.GetString(reader.GetOrdinal("surname"));
                    user.imageUrl = reader.GetString(reader.GetOrdinal("imageUrl"));
                    user.genderID = reader.GetString(reader.GetOrdinal("genderID"));
                    user.phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber"));
                    user.eMail = reader.GetString(reader.GetOrdinal("eMail"));
                    user.civilised = reader.GetBoolean(reader.GetOrdinal("civilised"));
                    user.address = reader.GetString(reader.GetOrdinal("address"));
                    user.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                    user.birthDate = reader.GetDateTime(reader.GetOrdinal("birthDate"));
                    user.enrolledDate = reader.GetDateTime(reader.GetOrdinal("enrolledDate"));
                  
                 
                    user.price = reader.GetDouble(reader.GetOrdinal("price"));
                    user.status = reader.GetBoolean(reader.GetOrdinal("status"));

                }

                reader.Close();
                connection.Close();
            }

            return user;
        }


        #endregion
        public List<User> GetCompaniesPersonel(int id)
        {
            var connection = new DbConnectionHelper().Connection;

            List<User> User = new List<User>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from [dbo].[User] where companyID=@ID";
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var user = new User();
                user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                user.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                user.name = reader.GetString(reader.GetOrdinal("name"));
                user.surname = reader.GetString(reader.GetOrdinal("surname"));
                user.imageUrl = reader.GetString(reader.GetOrdinal("imageUrl"));
                user.genderID = reader.GetString(reader.GetOrdinal("genderID"));
                user.phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber"));
                user.eMail = reader.GetString(reader.GetOrdinal("eMail"));
                user.civilised = reader.GetBoolean(reader.GetOrdinal("civilised"));
                user.address = reader.GetString(reader.GetOrdinal("address"));
                user.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                user.birthDate = reader.GetDateTime(reader.GetOrdinal("birthDate"));
                user.enrolledDate = reader.GetDateTime(reader.GetOrdinal("enrolledDate"));
        
                user.price = reader.GetDouble(reader.GetOrdinal("price"));
                user.status = reader.GetBoolean(reader.GetOrdinal("status"));

                User.Add(user);
            }
            reader.Close();
            connection.Close();


            return User;
        }
        #region LİSTELE
        public List<User> list() 
        {
            var connection = new DbConnectionHelper().Connection;

            List<User> User = new List<User>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from User";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var user = new User();
                user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                user.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                user.name = reader.GetString(reader.GetOrdinal("name"));
                user.surname = reader.GetString(reader.GetOrdinal("surname"));
                user.imageUrl = reader.GetString(reader.GetOrdinal("imageUrl"));
                user.genderID = reader.GetString(reader.GetOrdinal("genderID"));
                user.phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber"));
                user.eMail = reader.GetString(reader.GetOrdinal("eMail"));
                user.civilised = reader.GetBoolean(reader.GetOrdinal("civilised"));
                user.address = reader.GetString(reader.GetOrdinal("address"));
                user.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                user.birthDate = reader.GetDateTime(reader.GetOrdinal("birthDate"));
                user.enrolledDate = reader.GetDateTime(reader.GetOrdinal("enrolledDate"));
                user.exitDate = reader.GetDateTime(reader.GetOrdinal("exitDate"));
                user.price = reader.GetInt32(reader.GetOrdinal("price"));
                user.status = reader.GetBoolean(reader.GetOrdinal("status"));

                User.Add(user);
            }
            reader.Close();
            connection.Close();


            return User;
        }
        #endregion

        #region GÜNCELLE
        public void update(User t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"
            UPDATE [User] SET
            roleID = @RoleID,
            name = @Name,
            surname = @Surname,
            imageUrl = @ImageUrl,
            genderID = @GenderID,
            phoneNumber = @PhoneNumber,
            eMail = @Email,
            civilised = @Civilised,
            address = @Address,
            companyID = @CompanyID,
            birthDate = @BirthDate,
            enrolledDate = @EnrolledDate,
            exitDate = @ExitDate,
            price = @Price,
            status = @Status
            WHERE ID = @UserID";

                command.Parameters.AddWithValue("@RoleID", t.roleID);
                command.Parameters.AddWithValue("@Name", t.name);
                command.Parameters.AddWithValue("@Surname", t.surname);
                command.Parameters.AddWithValue("@ImageUrl", t.imageUrl);
                command.Parameters.AddWithValue("@GenderID", t.genderID);
                command.Parameters.AddWithValue("@PhoneNumber", t.phoneNumber);
                command.Parameters.AddWithValue("@Email", t.eMail);
                command.Parameters.AddWithValue("@Civilised", t.civilised);
                command.Parameters.AddWithValue("@Address", t.address);
                command.Parameters.AddWithValue("@CompanyID", t.companyID);
                command.Parameters.AddWithValue("@BirthDate", t.birthDate);
                command.Parameters.AddWithValue("@EnrolledDate", t.enrolledDate);
                command.Parameters.AddWithValue("@ExitDate", t.exitDate);
                command.Parameters.AddWithValue("@Price", t.price);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@UserID", t.ID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
