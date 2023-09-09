
using DataAccesLayer.Abstract;
using DataAccesLayer.Helpers;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repository
{
    public class CompaniesDAL : ICompaniesDAL
    {
        #region EKLEME
        public void add(Companies t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Companies values(@name,@description,@imageUrl,@enrolledDate,@exitDate,@address,@eMail,@phoneNumber,@sector,@status)";

            command.Parameters.AddWithValue("@name", t.name);
            command.Parameters.AddWithValue("@description", t.description);
            command.Parameters.AddWithValue("@imageUrl", t.imageUrl);
            command.Parameters.AddWithValue("@enrolledDate", t.enrolledDate);
            command.Parameters.AddWithValue("@exitDate", t.exitDate);
            command.Parameters.AddWithValue("@address", t.address);
            command.Parameters.AddWithValue("@eMail", t.eMail);
            command.Parameters.AddWithValue("@phoneNumber", t.phoneNumber);
            command.Parameters.AddWithValue("@sector", t.sector);
            command.Parameters.AddWithValue("@status", t.status);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(Companies t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Companies WHERE ID = @CompanyID";
            command.Parameters.AddWithValue("@CompanyID", t.ID);

        }

        public Companies GetByCompanyID(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ID'YEGOREGETIR
        public Companies GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            Companies company = null; // Declare a single instance

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Companies WHERE ID = @CompanyID";
                command.Parameters.AddWithValue("@CompanyID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    company = new Companies();
                    company.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    company.name = reader.GetString(reader.GetOrdinal("name"));
                    company.description = reader.GetString(reader.GetOrdinal("description"));
                    company.imageUrl = reader.GetString(reader.GetOrdinal("imageUrl"));
                    company.enrolledDate = reader.GetDateTime(reader.GetOrdinal("enrolledDate"));
                    company.exitDate = reader.GetDateTime(reader.GetOrdinal("exitDate"));
                    company.address = reader.GetString(reader.GetOrdinal("address"));
                    company.eMail = reader.GetString(reader.GetOrdinal("eMail"));
                    company.phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber"));
                    company.sector = reader.GetString(reader.GetOrdinal("sector"));
                    company.status = reader.GetBoolean(reader.GetOrdinal("status"));
                }

                reader.Close();
                connection.Close();
            }
            
            return company;
        }
        #endregion

        #region LİSTELE
        public List<Companies> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Companies> companies = new List<Companies>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Companies";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var Companies = new Companies();
                Companies.ID = reader.GetInt32("ID");
                Companies.name = reader.GetString("name");
                Companies.description = reader.GetString("description");
                Companies.imageUrl = reader.GetString("imageUrl");
                Companies.enrolledDate = reader.GetDateTime("enrolledDate");
                Companies.exitDate = reader.GetDateTime("exitDate");
                Companies.address = reader.GetString("address");
                Companies.eMail = reader.GetString("eMail");
                Companies.phoneNumber = reader.GetString("phoneNumber");
                Companies.sector = reader.GetString("sector");
                Companies.status = reader.GetBoolean("status");


                companies.Add(Companies);
            }
            reader.Close();
            connection.Close();


            return companies;
        }
        #endregion

        #region GÜNCELLE
        public void update(Companies t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"
            UPDATE Companies
            SET name = @Name,
                description = @Description,
                imageUrl = @ImageUrl,
                enrolledDate = @EnrolledDate,
                exitDate = @ExitDate,
                address = @Address,
                eMail = @Email,
                phoneNumber = @PhoneNumber,
                sector = @Sector,
                status = @Status
            WHERE ID = @CompanyID";

                command.Parameters.AddWithValue("@Name", t.name);
                command.Parameters.AddWithValue("@Description", t.description);
                command.Parameters.AddWithValue("@ImageUrl", t.imageUrl);
                command.Parameters.AddWithValue("@EnrolledDate", t.enrolledDate);
                command.Parameters.AddWithValue("@ExitDate", t.exitDate);
                command.Parameters.AddWithValue("@Address", t.address);
                command.Parameters.AddWithValue("@Email", t.eMail);
                command.Parameters.AddWithValue("@PhoneNumber", t.phoneNumber);
                command.Parameters.AddWithValue("@Sector", t.sector);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@CompanyID", t.ID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
