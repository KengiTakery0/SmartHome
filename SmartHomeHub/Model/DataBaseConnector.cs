using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace SmartHomeHub.Model
{
    public static class DataBaseConnector
    {
        public static string filePath { get; set; }
        public static SqliteConnection connection = new SqliteConnection(filePath);
        public static void Connect()
        {
            connection.Open();
        }
        public static void CreateUser(int id,string name,string lastName,string phoneNumber)
        {
            SqliteCommand cmd = new SqliteCommand();
            cmd.Connection = connection;
            cmd.CommandText = $"INSER INTO Users (id,Name,LastName,PhoneNumber) VALUES ({id},{name},{lastName},{phoneNumber})";
            cmd.ExecuteNonQuery();
        }
        public static void Disconnect()
        {
            connection.Close();
        }
    }
}
