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
    public class SuggestionsDAL : ISuggestionsDAL
    {
        #region EKLEME
        public void add(Suggestions t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Suggestions values(@title,@description,@companyID,@status)";

            command.Parameters.AddWithValue("@title", t.title);
            command.Parameters.AddWithValue("@description", t.description);
            command.Parameters.AddWithValue("@companyID", t.companyID);
            command.Parameters.AddWithValue("@status", t.status);


            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(Suggestions t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Suggestions WHERE ID = @SuggestionsID";
            command.Parameters.AddWithValue("@SuggestionsID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETİR
        public Suggestions GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            Suggestions suggestions = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Suggestions WHERE ID = @SuggestionsID";
                command.Parameters.AddWithValue("@SuggestionsID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    suggestions = new Suggestions();
                    suggestions.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    suggestions.title = reader.GetString(reader.GetOrdinal("title"));
                    suggestions.description = reader.GetString(reader.GetOrdinal("description"));
                    suggestions.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                    suggestions.status = reader.GetBoolean(reader.GetOrdinal("status"));


                }

                reader.Close();
                connection.Close();
            }

            return suggestions;
        }


        #endregion
        public List<Suggestions> GetUserSuggestionList(int id)
        {
            var connection = new DbConnectionHelper().Connection;

            List<Suggestions> Suggestions = new List<Suggestions>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Suggestions where companyID=@ID";
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var suggestions = new Suggestions();
                suggestions.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                suggestions.title = reader.GetString(reader.GetOrdinal("title"));
                suggestions.description = reader.GetString(reader.GetOrdinal("description"));
                suggestions.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                suggestions.status = reader.GetBoolean(reader.GetOrdinal("status"));

                Suggestions.Add(suggestions);
            }
            reader.Close();
            connection.Close();


            return Suggestions;
        }
        #region LİSTELE
        public List<Suggestions> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Suggestions> Suggestions = new List<Suggestions>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Suggestions";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var suggestions = new Suggestions();
                suggestions.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                suggestions.title = reader.GetString(reader.GetOrdinal("title"));
                suggestions.description = reader.GetString(reader.GetOrdinal("description"));
                suggestions.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                suggestions.status = reader.GetBoolean(reader.GetOrdinal("status"));

                Suggestions.Add(suggestions);
            }
            reader.Close();
            connection.Close();


            return Suggestions;
        }
        #endregion

        #region GÜNCELLE
        public void update(Suggestions t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"UPDATE Suggestions 
                               SET title = @Title, 
                                   description = @Description, 
                                   companyID = @CompanyID, 
                                   status = @Status 
                               WHERE ID = @SuggestionsID";

                command.Parameters.AddWithValue("@Title", t.title);
                command.Parameters.AddWithValue("@Description", t.description);
                command.Parameters.AddWithValue("@CompanyID", t.companyID);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@SuggestionsID", t.ID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
