using Database.Application.Interface;
using Npgsql;

namespace Database.Application.PostgresDatabase
{
    public class Repository : IRepository
    {
        private readonly IRepository _repository;
        public Repository(IRepository repository)
        {
            _repository = repository;
        }

        public async void Add(string Table,string entity)
        {
            await using var dataSource = NpgsqlDataSource.Create(Config.PostgresConnectionString);
            await using (var cmd = dataSource.CreateCommand($"INSERT INTO {Table} (some_field) VALUES ($1)"))
            {
                cmd.Parameters.AddWithValue(entity);
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
    }
}
