

namespace Database.Application.Interface
{
    public interface IRepository
    {
        List<string> GetAll();
        Task<string> GetById(int id);
        void UserAdd(string Login, string Password, string AccessToken);
        void Update(string entity);
        void Delete(string entity);
    }
}
