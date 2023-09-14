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
    public class RestDAL : IRestDAL
    {
        #region EKLEME
        public void add(Rest t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Rest values(@userID,@startDate,@endDate,@day,@isAccepted,@status)";

            command.Parameters.AddWithValue("@userID", t.userID);
            command.Parameters.AddWithValue("@startDate", t.startDate);
            command.Parameters.AddWithValue("@endDate", t.endDate);
            command.Parameters.AddWithValue("@day", t.day);
            command.Parameters.AddWithValue("@isAccepted", t.isAccepted);
            command.Parameters.AddWithValue("@status", t.status);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(Rest t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Rest WHERE ID = @RestID";
            command.Parameters.AddWithValue("@RestID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETİR
        public Rest GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            Rest rest = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Rest WHERE ID = @RestID";
                command.Parameters.AddWithValue("@RestID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    rest = new Rest();
                    rest.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    rest.userID = reader.GetInt32(reader.GetOrdinal("userID"));
                    rest.startDate = reader.GetDateTime(reader.GetOrdinal("startDate"));
                    rest.endDate = reader.GetDateTime(reader.GetOrdinal("endDate"));
                    rest.day = reader.GetInt32(reader.GetOrdinal("day"));
                    rest.isAccepted = reader.GetBoolean(reader.GetOrdinal("isAccepted"));
                    rest.status = reader.GetBoolean(reader.GetOrdinal("status"));


                }

                reader.Close();
                connection.Close();
            }

            return rest;
        }



        #endregion

        public List<Rest> GetCompanyRestList(int id)
        {
            var connection = new DbConnectionHelper().Connection;

            List<Rest> Rest = new List<Rest>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"SELECT R.[ID], R.[userID], R.[startDate], R.[endDate], R.[day], R.[isAccepted], R.[status]
FROM [KolayIK].[dbo].[Rest] R
INNER JOIN [KolayIK].[dbo].[User] U ON R.[userID] = U.[ID]
WHERE U.[companyID] = @ID ";
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var rest = new Rest();
                rest.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                rest.userID = reader.GetInt32(reader.GetOrdinal("userID"));
                rest.startDate = reader.GetDateTime(reader.GetOrdinal("startDate"));
                rest.endDate = reader.GetDateTime(reader.GetOrdinal("endDate"));
                rest.day = reader.GetInt32(reader.GetOrdinal("day"));
                rest.isAccepted = reader.GetBoolean(reader.GetOrdinal("isAccepted"));
                rest.status = reader.GetBoolean(reader.GetOrdinal("status"));

                Rest.Add(rest);
            }
            reader.Close();
            connection.Close();


            return Rest;
        }
        public List<Rest> GetUserRestList(int id)
        {
            var connection = new DbConnectionHelper().Connection;

            List<Rest> Rest = new List<Rest>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Rest where userID=@ID";
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var rest = new Rest();
                rest.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                rest.userID = reader.GetInt32(reader.GetOrdinal("userID"));
                rest.startDate = reader.GetDateTime(reader.GetOrdinal("startDate"));
                rest.endDate = reader.GetDateTime(reader.GetOrdinal("endDate"));
                rest.day = reader.GetInt32(reader.GetOrdinal("day"));
                rest.isAccepted = reader.GetBoolean(reader.GetOrdinal("isAccepted"));
                rest.status = reader.GetBoolean(reader.GetOrdinal("status"));

                Rest.Add(rest);
            }
            reader.Close();
            connection.Close();


            return Rest;
        }
        #region LİSTELE
        public List<Rest> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Rest> Rest = new List<Rest>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Rest";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var rest = new Rest();
                rest.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                rest.userID = reader.GetInt32(reader.GetOrdinal("userID"));
                rest.startDate = reader.GetDateTime(reader.GetOrdinal("startDate"));
                rest.endDate = reader.GetDateTime(reader.GetOrdinal("endDate"));
                rest.day = reader.GetInt32(reader.GetOrdinal("day"));
                rest.isAccepted = reader.GetBoolean(reader.GetOrdinal("isAccepted"));
                rest.status = reader.GetBoolean(reader.GetOrdinal("status"));

                Rest.Add(rest);
            }
            reader.Close();
            connection.Close();


            return Rest;
        }
        #endregion

        #region GÜNCELLE
        public void update(Rest t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"
            UPDATE Rest
            SET
                userID = @UserID,
                startDate = @StartDate,
                endDate = @EndDate,
                day = @Day,
                isAccepted = @IsAccepted,
                status = @Status
            WHERE ID = @RestID";

                command.Parameters.AddWithValue("@RestID", t.ID);
                command.Parameters.AddWithValue("@UserID", t.userID);
                command.Parameters.AddWithValue("@StartDate", t.startDate);
                command.Parameters.AddWithValue("@EndDate", t.endDate);
                command.Parameters.AddWithValue("@Day", t.day);
                command.Parameters.AddWithValue("@IsAccepted", t.isAccepted);
                command.Parameters.AddWithValue("@Status", t.status);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
