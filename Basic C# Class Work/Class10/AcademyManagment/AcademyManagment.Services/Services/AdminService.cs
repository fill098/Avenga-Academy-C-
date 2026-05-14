
using AcademyManagment.Domain;
using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Models;

namespace AcademyManagment.Services.Services
{
    public class AdminService
    {
        private DataAccess _dataAccess;

        public AdminService()
        {
            _dataAccess = new DataAccess();
        }

        //Login
        public Admin? AdminLogin(string username, string password)
        {
            Admin? adminFromDb = _dataAccess.GetAdmin(username, password);
            if (adminFromDb == null)
            {
                throw new Exception("Invalid credentilas. ry again!");
            }
            return adminFromDb;
        }
        //CreateUser
        public void CrateUser(string firstName, string lastName, string age, string username,string password, Role role)
        {
            bool userExists = _dataAccess.CheckIfUserExsist(username, role);
            if (userExists) 
            { 
                throw new Exception($@"{role.ToString()} with ""{username}""alredy exits");
            }
            _dataAccess.CrateNewUser(firstName, lastName, age, username, password, role);

        }
        //DeleteUser

        public void DeliteUser(string username, Role role)
        {
            bool userExites = _dataAccess.CheckIfUserExsist(username, role);
            if (!userExites)
            {
                throw new Exception("Cnnot delite user that dose not exites!");
            }
            _dataAccess.DeleteUser(username, role);
            
        }

        //GetUsersToRemove
        public List<string> GetUserToRemove(Role role, Admin loggedAdmin)
        {
            return _dataAccess.GetUserNames(role, loggedAdmin);
        }

    }
}
