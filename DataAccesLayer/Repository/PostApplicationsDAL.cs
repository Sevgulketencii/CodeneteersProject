using DataAccesLayer.Abstract;
using DataAccesLayer.Helpers;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repository
{
    public class PostApplicationsDAL :IPostApplicationsDAL
    {

        #region EKLEME
        public void Add(PostApplications t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into PostApplications values(@UserID, @PostID, @EnrolledDate, @CompanyID, @status)";

            command.Parameters.AddWithValue("@UserID", t.UserID);
            command.Parameters.AddWithValue("@PostID", t.PostID);
            command.Parameters.AddWithValue("@EnrolledDate", t.EnrolledDate);
            command.Parameters.AddWithValue("@companyID", t.CompanyID);
            command.Parameters.AddWithValue("@status", t.status);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region POSTID'YE GÖRE BAŞVURU SAYISI GETİRME

        public List<PostApplications> GetParticipantsListByPostID(Posts t)
        {
            var connection = new DbConnectionHelper().Connection;
            List<PostApplications> participants = new List<PostApplications>();

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"Select pA.UserID, pA.EnrolledDate From PostApplications pA
                                    left join Posts p
                                    on p.ID = pA.PostID
                                    where pA.CompanyID =@companyID and PostID=@postID";
            command.Parameters.AddWithValue("@companyID", t.companyID);
            command.Parameters.AddWithValue("@postID", t.ID);

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var participant = new PostApplications();
                participant.UserID = reader.GetInt32(reader.GetOrdinal("userID"));
                participant.EnrolledDate = reader.GetDateTime(reader.GetOrdinal("EnrolledDate"));
                participants.Add(participant);
            }

            reader.Close();
            connection.Close();
            return participants;
        }
        #endregion

    }
}
