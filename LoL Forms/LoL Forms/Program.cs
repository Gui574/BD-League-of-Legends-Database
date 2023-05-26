using System.Data.SqlClient;

namespace LoL_Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Regions());
        }
    }

    public static class DatabaseConnection
    {
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                // Establish the database connection
                string connectionString = "Server=bdadmin.database.windows.net;Database=LoLDatabase;User Id=bdadmin;Password=Password2023;";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }
    }

}