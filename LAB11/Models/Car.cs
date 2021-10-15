using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LAB11.Models
{
    public class Car
    {
        private static readonly string _selectCarsCommand = @"SELECT [AutoId], [Number], [ProducerId] FROM [dbo].[Auto]";
        private static readonly string _insertCarsCommand = @"INSERT INTO [dbo].[Auto] ([Number], [ProducerId]) VALUES (@Number, @ProducerId)";
        private static readonly string _updateCarsCommand = @"UPDATE [dbo].[Auto] SET [Number] = @Number, [ProducerId] = @ProducerId WHERE [AutoId] = @AutoId";
        private static readonly string _deleteCarsCommand = @"DELETE FROM [dbo].[Auto] WHERE [AutoId] = @AutoId";
        public int AutoId { get; set; }
        public string Number { get; set; }
        public int ProducerId { get; set; }

        public byte[] Photo { get; set; }

        public static List<Car> List(SqlConnection connection)
        {
            List<Car> cars = new List<Car>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectCarsCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Car car = new Car
                        {
                            Number = (string)reader["Number"],
                            ProducerId = (int)reader["ProducerId"],
                            AutoId = (int)reader["AutoId"]
                        };
                        cars.Add(car);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return cars;
        }

        public static void Insert(SqlConnection connection, Car car)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertCarsCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Number", SqlDbType.NVarChar, 12).Value = car.Number;
                    command.Parameters.Add("@ProducerID", SqlDbType.Int).Value = car.ProducerId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static void Update(SqlConnection connection, Car car)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateCarsCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Number", SqlDbType.NVarChar, 12).Value = car.Number;
                    command.Parameters.Add("@ProducerID", SqlDbType.Int).Value = car.ProducerId;
                    command.Parameters.Add("@AutoId", SqlDbType.Int).Value = car.AutoId;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
        public static void Delete(SqlConnection connection, int carId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteCarsCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@AutoId", SqlDbType.Int).Value = carId;
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
