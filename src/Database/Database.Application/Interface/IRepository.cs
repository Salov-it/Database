

namespace Database.Application.Interface
{
    public interface IRepository
    {
        void UserCreateTable();
        void UserAdd(string Login, string Password, string AccessToken);
        List<string> GetAll();
        Task<string> GetById(int id);
        void Update(string entity);
        void Delete(string entity);
    }
}
