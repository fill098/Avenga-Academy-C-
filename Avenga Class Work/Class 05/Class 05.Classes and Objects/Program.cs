

#region Classes deffinition and creating instant objects





// Create a Person object usining the parametar constructor and set propertis manually




//Create a Person object usinig the object initialazer syintax



















#endregion

#region Working with Classes

Grope g1 = new Grope("G1", 12, "BasicC#");
Grope g2 = new Grope("G2", 12, "Web development usng NodeJs");

Student mario = new Student("mario", 34, g1);
Student dimitar = new Student("dimitar", 19, g1);
Student tomi = new Student("Tomi Tomi", 32, g2);

Student ivo = new Student("Ivo Kostovski", 36, new Grope("G3", 10, "HTML/CSS"));

Student cvetko = new Student("Cvetko Cvetkoski", 35, new Grope()
{
    GroupNAme = "G3",
    NUmberOfStudents = 10,
    CurentSubjectName = "HTML/CSS"
});


mario.DisplayStudentInfo();
dimitar.DisplayStudentInfo();
tomi.DisplayStudentInfo();
ivo.DisplayStudentInfo();
cvetko.DisplayStudentInfo();


Student filip = new Student("Filip MIhajlovski", 27, null);
filip.DisplayStudentInfo();


#endregion
