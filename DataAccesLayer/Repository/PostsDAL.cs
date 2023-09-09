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
    public class PostsDAL : IPostsDAL
    {
        #region EKLEME
        public void add(Posts t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into Posts values(@roleID,@title,@body,@companyID,@createdDate,@status, @type)";

            command.Parameters.AddWithValue("@roleID", t.roleID);
            command.Parameters.AddWithValue("@title", t.title);
            command.Parameters.AddWithValue("@body", t.body);
            command.Parameters.AddWithValue("@companyID", t.companyID);
            command.Parameters.AddWithValue("@createdDate", t.createdDate);
            command.Parameters.AddWithValue("@status", t.status);
            command.Parameters.AddWithValue("@type", t.type);

            connection.Open();
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.Close();
        }
        #endregion

        #region SİLME
        public void delete(Posts t)
        {
            var connection = new DbConnectionHelper().Connection;
            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM Posts WHERE ID = @PostsID";
            command.Parameters.AddWithValue("@PostsID", t.ID);
        }
        #endregion

        #region ID'YEGOREGETIR
        public Posts GetByID(int id)
        {
            var connection = new DbConnectionHelper().Connection;
            Posts post = null;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Posts WHERE ID = @PostsID";
                command.Parameters.AddWithValue("@PostsID", id);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    post = new Posts();
                    post.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    post.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                    post.title = reader.GetString(reader.GetOrdinal("title"));
                    post.body = reader.GetString(reader.GetOrdinal("body"));
                    post.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                    post.createdDate = reader.GetDateTime(reader.GetOrdinal("createdDate"));
                    post.status = reader.GetBoolean(reader.GetOrdinal("status"));
                    post.type = reader.GetString(reader.GetOrdinal("type"));


                }

                reader.Close();
                connection.Close();
            }

            return post;
        }
        #endregion

        #region LİSTELE
        public List<Posts> list()
        {
            var connection = new DbConnectionHelper().Connection;

            List<Posts> Posts = new List<Posts>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from Posts";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var post = new Posts();
                post.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                post.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                post.title = reader.GetString(reader.GetOrdinal("title"));
                post.body = reader.GetString(reader.GetOrdinal("body"));
                post.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                post.createdDate = reader.GetDateTime(reader.GetOrdinal("createdDate"));
                post.status = reader.GetBoolean(reader.GetOrdinal("status"));
                post.type = reader.GetString(reader.GetOrdinal("type"));

                Posts.Add(post);
            }
            reader.Close();
            connection.Close();


            return Posts;
        }
        #endregion

        #region GÜNCELLE
        public void update(Posts t)
        {
            var connection = new DbConnectionHelper().Connection;

            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
                command.CommandText = @"
            UPDATE Posts
            SET
                roleID = @RoleID,
                title = @Title,
                body = @Body,
                companyID = @CompanyID,
                createdDate = @CreatedDate,
                status = @Status,
                type = @type
            WHERE ID = @PostsID";

                command.Parameters.AddWithValue("@RoleID", t.roleID);
                command.Parameters.AddWithValue("@Title", t.title);
                command.Parameters.AddWithValue("@Body", t.body);
                command.Parameters.AddWithValue("@CompanyID", t.companyID);
                command.Parameters.AddWithValue("@CreatedDate", t.createdDate);
                command.Parameters.AddWithValue("@Status", t.status);
                command.Parameters.AddWithValue("@PostsID", t.ID);
                command.Parameters.AddWithValue("@type", t.type);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region ŞİRKETE GÖRE LİSTELE
        public List<Posts> GetCompanyPostList(int id)
        {
            var connection = new DbConnectionHelper().Connection;

            List<Posts> Posts = new List<Posts>();


            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = @"select * from [dbo].[Posts] where companyID=@ID";
            command.Parameters.AddWithValue("@ID", id);
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {

                var post = new Posts();
                post.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                post.roleID = reader.GetInt32(reader.GetOrdinal("roleID"));
                post.title = reader.GetString(reader.GetOrdinal("title"));
                post.body = reader.GetString(reader.GetOrdinal("body"));
                post.companyID = reader.GetInt32(reader.GetOrdinal("companyID"));
                post.createdDate = reader.GetDateTime(reader.GetOrdinal("createdDate"));
                post.status = reader.GetBoolean(reader.GetOrdinal("status"));
                post.type = reader.GetString(reader.GetOrdinal("type"));

                Posts.Add(post);
            }
            reader.Close();
            connection.Close();


            return Posts;
        }
    }
    #endregion
}

