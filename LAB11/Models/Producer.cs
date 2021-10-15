using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LAB11.Models
{
    public class Producer
    {
        private static readonly string _selectProducersCommand = @"SELECT [ProducerId], [Title], [Country] FROM [dbo].[Producer]";
        private static readonly string _insertProducersCommand = @"INSERT INTO [dbo].[Producer] ([Title], [Country]) VALUES (@Title, @Country)";
        private static readonly string _updateProducersCommand = @"UPDATE [dbo].[Producer] SET [Title] = @Title, [Country] = @Country WHERE [ProducerId] = @ProducerId";
        private static readonly string _deleteProducersCommand = @"DELETE FROM [dbo].[Producer] WHERE [ProducerId] = @ProducerId";

        public int ProducerId { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }

        public static List<Producer> List(SqlConnection connection)
        {
            List<Producer> producers = new List<Producer>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectProducersCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Producer car = new Producer
                        {
                            ProducerId = (int)reader["ProducerId"],
                            Title = (string)reader["Title"],
                            Country = (string)reader["Country"]
                        };
                        producers.Add(car);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return producers;
        }
        public static void Insert(SqlConnection connection, Producer producer)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertProducersCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Title", SqlDbType.NVarChar, 25).Value = producer.Title;
                    command.Parameters.Add("@Country", SqlDbType.NVarChar, 25).Value = producer.Country;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static void Update(SqlConnection connection, Producer producer)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateProducersCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Title", SqlDbType.NVarChar, 25).Value = producer.Title;
                    command.Parameters.Add("@Country", SqlDbType.NVarChar, 25).Value = producer.Country;
                    command.Parameters.Add("@ProducerId", SqlDbType.NVarChar, 25).Value = producer.ProducerId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static void Delete(SqlConnection connection, int producerId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteProducersCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@ProducerId", SqlDbType.Int).Value = producerId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
