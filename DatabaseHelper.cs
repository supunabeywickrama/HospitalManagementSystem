using System.Data;
using System.Data.SqlClient;

public static class DatabaseHelper
{
    private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public static DataTable ExecuteQuery(string query, SqlParameter[] parameters)
    {
        using (SqlConnection connection = GetConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
    {
        using (SqlConnection connection = GetConnection())
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
