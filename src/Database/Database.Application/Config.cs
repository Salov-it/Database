

namespace Database.Application
{
    public class Config
    {
        public static string PostgresConnectionString = $"Server={Localhost};Port={Port};Database={DatabaseName};User Id={Login};Password={Password};";

        public static string Localhost = "localhost";
        public static string Login = "postgres";
        public static string Password = "Salov_1999";
        public static string DatabaseName = "VkSpamerBase";
        public static int Port = 5432;
    }
}
