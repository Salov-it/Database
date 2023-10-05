using Database.Application.Model;

namespace Database.Application.Interface
{
    public interface IRepository
    {
        void UserCreateTable();
        void UserAdd(string Login, string Password, string AccessToken);
       Task<List<UsersTableModel>> GetAll();
        Task<string> GetById();
        void Update();
        void Delete();
    }
}
