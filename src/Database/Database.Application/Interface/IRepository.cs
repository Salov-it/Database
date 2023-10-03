

namespace Database.Application.Interface
{
    public interface IRepository
    {
        List<string> GetAll();
        Task<string> GetById(int id);
        void Add(string Table, string entity, string Fields, string VALUES);
        void Update(string entity);
        void Delete(string entity);
    }
}
