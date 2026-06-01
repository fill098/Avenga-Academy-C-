#region Paths

// Absolut Path 
string studentRepoReadmeFullPath = @"C:\Users\code\Desktop";

string studentRepoFilipFile = @"C:\Users\code\Desktop\Filip.tx";


// Relativ Path

string classRelativPatth = @"..\..\..\..\Filip.tx";





#endregion

#region Directory
// Get curetn directory

string currentDirectory = Directory.GetCurrentDirectory();

Console.WriteLine($"Current Directory: {currentDirectory}");

// Check if folder exists

string testFolderPath = @"..\..\..\TestFolder";

bool testFolderExists = Directory.Exists(testFolderPath);

Console.WriteLine($"{testFolderExists}");

// Create floder if it dose not exits

if (!testFolderExists)
{
    Directory.CreateDirectory(testFolderPath);
    Console.WriteLine("Succefully created TestFolder.");
}
else
{
    Console.WriteLine("TestFolder alrady exists.");

}

// Delete a folder

//if (Directory.Exists(testFolderPath))
//{
//    Directory.Delete(testFolderPath);
//}

#endregion


#region File

// Check if a file exits

testFolderPath = @"..\..\..\TestFolder";

string fileName = "example.txt";

//string filePath = $@"{testFolderPath}\{fileName}";

string filePath = Path.Combine(testFolderPath, fileName);
bool fileExists = File.Exists(filePath);


// Create new file

if (!Directory.Exists(testFolderPath))
{
    Directory.CreateDirectory(testFolderPath);
}

if (!fileExists)
{
    File.Create(filePath).Close();
}
else
{
    Console.WriteLine("File alrady exists!!");
}


// Delete a file

//if (File.Exists(filePath))
//{
//    File.Delete(filePath);
//    Console.WriteLine("Succefully deleted file: example.txt");
//}

// Write in to the file

File.WriteAllText(filePath, "Hello from SEDC :)\n");

//File.WriteAllText(filePath, "Hello from Avenga Academy");

File.AppendAllText(filePath, "Hello from Avenga Academy");

// Read from file 


string fileContent = File.ReadAllText(filePath);

Console.WriteLine("File content\n");

Console.WriteLine(fileContent);

// Get file info

FileInfo fileInfo = new FileInfo(filePath);

Console.WriteLine(fileInfo.FullName);
Console.WriteLine(fileInfo.Name);
Console.WriteLine(fileInfo.Extension);
Console.WriteLine(fileInfo.Length);
Console.WriteLine(fileInfo.LastWriteTime);










#endregion