
using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Models;

namespace AcademyManagment.Domain
{
    public class DataAccess
    {
        private Database _db;

        public DataAccess()
        {
            _db = new Database();
        }


        public Admin? GetAdmin(string username, string password) 
        {
            Admin? adminFromDb = _db.Admins.FirstOrDefault(x => x.Usename == username && x.Password == password);
            return adminFromDb;
        }




        public Trainer? GetTrainer(string username, string password) 
        {
            Trainer? trainerFromDb = _db.Trainers.FirstOrDefault(x => x.Usename == username && x.Password == password);
            return trainerFromDb;
        }


        public Student? GetStudent(string username, string password) 
        {
            Student? studentFromDb = _db.Students.FirstOrDefault(x => x.Usename == username && x.Password == password);
            return studentFromDb;
        }


        public bool CheckIfUserExsist(string username, Role role) 
        {
            switch (role)
            {
                case Role.Admin:
                    return _db.Admins.Any(x => x.Usename.ToLower().Trim() == username.ToLower().Trim());
                    
                case Role.Trainer:
                    return _db.Trainers.Any(x => x.Usename.ToLower().Trim() == username.ToLower().Trim());
                    
                case Role.Student:
                    return _db.Students.Any(x => x.Usename.ToLower().Trim() == username.ToLower().Trim());
                    
                default:
                    return false;
            }
        }

        public List<string> GetUserNames(Role role, Admin loggedAdmin)
        {
            switch (role)
            {
                case Role.Admin:
                    return _db.Admins.Where(x => x.Usename != loggedAdmin.Usename).Select(x => x.Usename).ToList();
                    
                case Role.Trainer:
                    return _db.Trainers.Select(x => x.Usename).ToList();
                    
                case Role.Student:
                    return _db.Students.Select(x => x.Usename).ToList();
                    
                default:
                    throw new Exception($"Error occurd while retriving usernames from data base");
                   
            }

        }


        public void CrateNewUser(string firstName, string lastName, string age, string username, string password, Role role) 
        {
            switch (role)
            {
                case Role.Admin:
                    Admin newAdmin = new Admin(firstName, lastName, username, password, int.Parse(age));
                    _db.Admins.Add(newAdmin);
                    break;
                case Role.Trainer:
                    Trainer newTrainer = new Trainer(firstName, lastName, username, password, int.Parse(age));
                    _db.Trainers.Add(newTrainer);
                    break;
                case Role.Student:
                    Student newStudent = new Student(firstName, lastName, username, password, int.Parse(age));
                    _db.Students.Add(newStudent);
                    break;
                default:
                    break;
            }

            

        }

        public bool DeleteUser(string username, Role role) 
        {
            switch (role)
            {
                case Role.Admin:
                    Admin? adminFromDb = _db.Admins.FirstOrDefault(x => x.Usename.ToLower().Trim() == username.ToLower().Trim());
                     return _db.Admins.Remove(adminFromDb);
                case Role.Trainer:
                    Trainer? trainerFromDb = _db.Trainers.FirstOrDefault(x => x.Usename.ToLower().Trim() == username.ToLower().Trim());
                    return _db.Trainers.Remove(trainerFromDb);
                   
                case Role.Student:
                    Student? studentFromDb = _db.Students.FirstOrDefault(x => x.Usename.ToLower().Trim() == username.ToLower().Trim());
                    return _db.Students.Remove(studentFromDb);
                default:
                    return false;
            }
        }
    }
}
