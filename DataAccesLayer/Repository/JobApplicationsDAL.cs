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
    public class JobApplicationsDAL : IJobApplicationsDAL
    {
        #region EKLEME
        public void add(JobApplications t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into JobApplications values(@userID,@JobAdvertisementID,@createdDate,@situation,@status)";

            command.Parameters.AddWithValue("@userID", t.userID);
            command.Parameters.AddWithValue("@JobAdvertisementID", t.JobAdvertisementID);
            command.Parameters.AddWithValue("@createdDate", t.createdDate);
            command.Parameters.AddWithValue("@situation", t.situation);
            command.Parameters.AddWithValue("@status", t.status);



            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(JobApplications t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM JobApplications WHERE ID = @JobApplicationsID";
            command.Parameters.AddWithValue("@JobApplicationsID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETİR
        public JobApplications GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            JobApplications JobApplications = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM JobApplications WHERE ID = @JobApplicationsID";
                command.Parameters.AddWithValue("@JobApplicationsID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    JobApplications = new JobApplications();
                    JobApplications.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    JobApplications.userID = reader.GetInt32(reader.GetOrdinal("ID"));
                    JobApplications.JobAdvertisementID = reader.GetInt32(reader.GetOrdinal("JobAdvertisementID"));
                    JobApplications.createdDate = reader.GetDateTime(reader.GetOrdinal("createdDate"));
                    JobApplications.situation = reader.GetString(reader.GetOrdinal("situation"));
                    JobApplications.status = reader.GetBoolean(reader.GetOrdinal("status"));

                }

                reader.Close();
                connection.Close();
            }

            return JobApplications;
        }
        #endregion

        #region LİSTELE
        public List<JobApplications> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<JobApplications> jobApplications = new List<JobApplications>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from JobApplications";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var JobApplications = new JobApplications();
                JobApplications.ID = reader.GetInt32("ID");
                JobApplications.userID = reader.GetInt32(reader.GetOrdinal("ID"));
                JobApplications.JobAdvertisementID = reader.GetInt32(reader.GetOrdinal("JobAdvertisementID"));
                JobApplications.createdDate = reader.GetDateTime(reader.GetOrdinal("createdDate"));
                JobApplications.situation = reader.GetString(reader.GetOrdinal("situation"));
                JobApplications.status = reader.GetBoolean(reader.GetOrdinal("status"));


                jobApplications.Add(JobApplications);
            }
            reader.Close();
            connection.Close();


            return jobApplications;
        }
        #endregion

        #region GÜNCELLEME
        public void update(JobApplications t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"
            UPDATE JobApplications
            SET
                userID = @UserID,
                JobAdvertisementID = @JobAdvertisementID,
                createdDate = @CreatedDate,
                situation = @Situation,
                status = @Status
                WHERE ID = @JobApplicationsID ";

                command.Parameters.AddWithValue("@JobApplicationsID", t.ID);
                command.Parameters.AddWithValue("@UserID", t.userID);
                command.Parameters.AddWithValue("@JobAdvertisementID", t.JobAdvertisementID);
                command.Parameters.AddWithValue("@CreatedDate", t.createdDate);
                command.Parameters.AddWithValue("@Situation", t.situation);
                command.Parameters.AddWithValue("@Status", t.status);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
