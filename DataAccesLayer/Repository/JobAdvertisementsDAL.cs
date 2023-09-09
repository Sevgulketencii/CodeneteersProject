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
    public class JobAdvertisementsDAL : IJobAdvertisementsDAL
    {
        #region EKLEME
        public void add(JobAdvertisements t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into JobAdvertisements values(@title,@body,@companyID,@createdDate,@category,@status)";

            command.Parameters.AddWithValue("@title", t.title);
            command.Parameters.AddWithValue("@body", t.body);
            command.Parameters.AddWithValue("@companyID", t.companyID);
            command.Parameters.AddWithValue("@createdDate", t.createdDate);
            command.Parameters.AddWithValue("@category", t.category);
            command.Parameters.AddWithValue("@status", t.status);


            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(JobAdvertisements t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM JobAdvertisements WHERE ID = @JobAdvertisementsID";
            command.Parameters.AddWithValue("@JobAdvertisementsID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETIR
        public JobAdvertisements GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            JobAdvertisements jobAdvertisements = null; 

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM JobAdvertisements WHERE ID = @JobAdvertisementsID";
                command.Parameters.AddWithValue("@JobAdvertisementsID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    jobAdvertisements = new JobAdvertisements();
                    jobAdvertisements.ID = reader.GetInt32("ID");
                    jobAdvertisements.title = reader.GetString("title");
                    jobAdvertisements.body = reader.GetString(reader.GetOrdinal("body"));
                    jobAdvertisements.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                    jobAdvertisements.createdDate = reader.GetDateTime(reader.GetOrdinal("createdDate"));
                    jobAdvertisements.category = reader.GetString(reader.GetOrdinal("category"));
                    jobAdvertisements.status = reader.GetBoolean(reader.GetOrdinal("status"));
                }

                reader.Close();
                connection.Close();
            }

            return jobAdvertisements;
        }


        #endregion
        public List<JobAdvertisements> GetCompanyJoblist(int id)
        {
            var connection = new DbConnectionHelper().Connection;

            List<JobAdvertisements> jobAdvertisements = new List<JobAdvertisements>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from JobAdvertisements where companyID=@ID";
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var JobAdvertisements = new JobAdvertisements();
                JobAdvertisements.ID = reader.GetInt32("ID");
                JobAdvertisements.title = reader.GetString("title");
                JobAdvertisements.body = reader.GetString("body");
                JobAdvertisements.companyID = reader.GetInt32("companyID");
                JobAdvertisements.createdDate = reader.GetDateTime("createdDate");
                JobAdvertisements.category = reader.GetString("category");
                JobAdvertisements.status = reader.GetBoolean("status");

                jobAdvertisements.Add(JobAdvertisements);
            }
            reader.Close();
            connection.Close();


            return jobAdvertisements;
        }
        #region LİSTELE
        public List<JobAdvertisements> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<JobAdvertisements> jobAdvertisements = new List<JobAdvertisements>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from JobAdvertisements";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
				var JobAdvertisements = new JobAdvertisements();
				JobAdvertisements.ID = reader.GetInt32("ID");
				JobAdvertisements.title = reader.GetString("title");
				JobAdvertisements.body = reader.GetString("body");
				JobAdvertisements.companyID = reader.GetInt32("companyID");
				JobAdvertisements.createdDate = reader.GetDateTime("createdDate");
				JobAdvertisements.category = reader.GetString("category");
				JobAdvertisements.status = reader.GetBoolean("status");

				jobAdvertisements.Add(JobAdvertisements);
            }
            reader.Close();
            connection.Close();


            return jobAdvertisements;
        }
        #endregion

        #region GÜNCELLE
        public void update(JobAdvertisements t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"
            UPDATE JobAdvertisements
            SET title = @Title,
                body = @Body,
                companyID = @CompanyID,
                createdDate = @CreatedDate,
                category = @Category,
                status = @Status
            WHERE ID = @JobAdvertisementID";

                command.Parameters.AddWithValue("@Title", t.title);
                command.Parameters.AddWithValue("@Body", t.body);
                command.Parameters.AddWithValue("@CompanyID", t.companyID);
                command.Parameters.AddWithValue("@CreatedDate", t.createdDate);
                command.Parameters.AddWithValue("@Category", t.category);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@JobAdvertisementID", t.ID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
