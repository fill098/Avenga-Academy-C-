

using AcademyManagement.Domain.Enum;
using AcademyManagement.Domain.Models;

namespace AcademyManagement.Domain
{
    public class DataAccess
    {
        private DataBase _data;

        public DataAccess()
        {
            _data = new DataBase();
        }



        public Admin? GetAdmin(string username, string password)
        {
            Admin? adminFromData = _data.Admins
                .FirstOrDefault(x => x.UserName == username && x.Password == password);
            return adminFromData;
        }





        public Trainer? GetTrener(string username, string password)
        {
            Trainer? trainerFromData = _data.Trainers
                .FirstOrDefault(x => x.UserName == username && x.Password == password);
            return trainerFromData;
        }



        public Student? GetStudent(string username, string password)
        {
            Student? studentFromData = _data.Students
                .FirstOrDefault(x => x.UserName == username && x.Password == password);
            return studentFromData;
        }





        public bool CheckIfUserExsists(string username, Role role) 
        {
                switch (role)
                {
                    case Role.Admin:
                        return _data.Admins.Any(x => x.UserName.ToLower().Trim() == username.ToLower().Trim());
                    case Role.Trainer:
                        return _data.Trainers.Any(x => x.UserName.ToLower().Trim() == username.ToLower().Trim());
                    case Role.Student:
                        return _data.Students.Any(x => x.UserName.ToLower().Trim() == username.ToLower().Trim());
                    default:
                        return false;
                }
        }



        public List<string>  GetUserNames(Role role, Admin loggedAdmin)

        {
            switch (role)
            {
                case Role.Admin:
                    return _data.Admins.Where(x => x.UserName != loggedAdmin.UserName)
                            .Select(x => x.UserName).ToList();
                case Role.Trainer:
                    return _data.Trainers.Select(x => x.UserName).ToList();
                case Role.Student:
                    return _data.Students.Select(x => x.UserName).ToList();
                default:
                    throw new Exception("Error occured while retriving usrenames from data base");
            }

        }


        public void CreateNewUser(string fname, string lname, string age, string username, string password, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    Admin newAdmin = new Admin(fname, lname, username, password, int.Parse(age));
                    _data.Admins.Add(newAdmin);
                    break;
                case Role.Trainer:
                    Trainer newTrainer = new Trainer(fname, lname, username, password, int.Parse(age));
                    _data.Trainers.Add(newTrainer);
                    break;
                case Role.Student:

                    Student newStudent = new Student(fname, lname, username, password, int.Parse(age));
                    _data.Students.Add(newStudent);
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
                    Admin? adminFromData = _data.Admins.FirstOrDefault(x => x.UserName.ToLower().Trim() == username.ToLower().Trim());
                    return _data.Admins.Remove(adminFromData);
                case Role.Trainer:
                    Trainer? trainerFromData = _data.Trainers.FirstOrDefault(x => x.UserName.ToLower().Trim() == username.ToLower().Trim());
                    return _data.Trainers.Remove(trainerFromData);
                    
                case Role.Student:
                    Student? studentFromData = _data.Students.FirstOrDefault(x => x.UserName.ToLower().Trim() == username.ToLower().Trim());
                    return _data.Students.Remove(studentFromData);
                    
                default:
                   return false;
            }


        }












    }
}
