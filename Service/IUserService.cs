using api_learning_project.Model;

namespace api_learning_project.Service
{
    public interface IUserService
    {
        public bool CreateAccount(string username, string password, string email);
        public bool CheckUsernameExists(string username);
        public bool CheckEmailExists(string email);
    }
}
