

using Class11.Realization_and_Realisation;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

void WriteInFile(string path, string text)
{
    using(StreamWriter  sw = new StreamWriter(path))
    {
        sw.WriteLine(text);
    }
}

string ReadFromFile(string path)
{
    using (StreamReader sr = new StreamReader(path))
    {
        return sr.ReadToEnd();
    }
}


string directoryPath = @"..\..\..\OurData";
string filePath = Path.Combine(directoryPath, "myFirstJson.json"); ;



if (!Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
}


Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobski",
    Age = 33,
    IsPartTime = false,
};



WriteInFile(filePath, bob.ToString());

#region NewtonSoft JSON 


string bobSeralizedNewtomsoftJson = JsonConvert.SerializeObject(bob, Formatting.Indented);
WriteInFile(filePath, bobSeralizedNewtomsoftJson);


Student bobDeseralzizedNwetonSoft = JsonConvert.DeserializeObject<Student>(bobSeralizedNewtomsoftJson);

#endregion