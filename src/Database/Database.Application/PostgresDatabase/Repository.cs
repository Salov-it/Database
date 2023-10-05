using Database.Application.Interface;
using Npgsql;

namespace Database.Application.PostgresDatabase
{
    public class Repository : IRepository
    {
        private readonly string _connect;
        Config config = new Config();
        public Repository()
        {
            _connect = config.PostgresConnectionString;
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

        public void Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(string entity)
        {
            throw new NotImplementedException();
        }

        public void UserCreateTable()
        {
            throw new NotImplementedException();
        }
    }
}
