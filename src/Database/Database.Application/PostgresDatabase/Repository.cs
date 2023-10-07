using Database.Application.Interface;
using Database.Application.Model;
using Npgsql;

namespace Database.Application.PostgresDatabase
{
    public class Repository : IRepository
    {
        private readonly string _connect;
        public List<UsersTableModel> GetAllResult = new List<UsersTableModel>();
        public UsersTableModel ResultGetById { get; set; }
        Config config = new Config();
        public Repository()
        {
            _connect = config.PostgresConnectionString;
        }

        public async void UserCreateTable()
        {
            await using var dataSource = NpgsqlDataSource.Create(_connect);
            await using (var cmd = dataSource.CreateCommand("CREATE TABLE Users (id SERIAL PRIMARY KEY,Login TEXT,Password TEXT,AccessToken TEXT);"))
            {
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async void UserAdd(string Login,string Password,string AccessToken)
        {
            await using var dataSource = NpgsqlDataSource.Create(_connect);
            await using (var cmd = dataSource.CreateCommand("INSERT INTO Users (login,password,accesstoken) VALUES (@Login,@Password,@AccessToken)"))
            {
                cmd.Parameters.AddWithValue("Login",Login);
                cmd.Parameters.AddWithValue("Password",Password);
                cmd.Parameters.AddWithValue("AccessToken",AccessToken);
                await cmd.ExecuteNonQueryAsync();
            }  
        }

        public async Task<List<UsersTableModel>> GetAll()
        {
            await using var dataSource = NpgsqlDataSource.Create(_connect);
            await using (var cmd = dataSource.CreateCommand("SELECT * FROM Users;"))
            {
                await using var reader = await cmd.ExecuteReaderAsync();
               
                while (await reader.ReadAsync())
                {
                    var login = reader.GetString(0);
                    var password = reader.GetString(1);
                    var accessToken = reader.GetString(2);
                    UsersTableModel usersTable = new UsersTableModel
                    {
                        Login = login,
                        Password = password,
                        AccessToken = accessToken
                    };
                    GetAllResult.Add(usersTable);
                }
                return GetAllResult;
               
            }
        }

        public async Task<UsersTableModel> GetById(int id)
        {
            await using var dataSource = NpgsqlDataSource.Create(_connect);
            await using (var cmd = dataSource.CreateCommand($"SELECT login,password,accesstoken FROM Users WHERE id = {id};"))
            {
                await using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var login = reader.GetString(0);
                    var password = reader.GetString(1);
                    var accessToken = reader.GetString(2);
                    UsersTableModel usersTable = new UsersTableModel
                    {
                        Login = login,
                        Password = password,
                        AccessToken = accessToken
                    };
                    ResultGetById = usersTable;
                }
                return ResultGetById;
            }
            
        }
        public async void Delete()
        {
            await using var dataSource = NpgsqlDataSource.Create(_connect);
            await using (var cmd = dataSource.CreateCommand("DROP TABLE Users;"))
            {
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
