

// SETUP
string folderPath = @"..\..\..\TestFiles";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

string fileName = "notes.txt";
string filePath = Path.Combine(folderPath, fileName);

try
{
    using (StreamWriter streamWriter = new StreamWriter(filePath))
    {
        streamWriter.WriteLine("This is a sample note.");
        streamWriter.WriteLine("StreamWriter lets us write text line by line effeciently.");
        streamWriter.WriteLine("It also allows you to append OR overWrite.");

    }

    using (StreamWriter streamWriter = new StreamWriter(filePath, true))
    {
        streamWriter.WriteLine("NEW This is a sample note.");
        streamWriter.WriteLine("NEW StreamWriter lets us write text line by line effeciently.");
        streamWriter.WriteLine("NEW It also allows you to append OR overWrite.");

    }

}
catch (Exception ex)
{

    Console.WriteLine("Error writnig in file. Error:" + ex.Message);
}


try
{
    using (StreamReader streamReader = new StreamReader(filePath))
    {
        Console.WriteLine("Reading file content StreamReader");
        string firstLine = streamReader.ReadLine();
        Console.WriteLine("First line: " + firstLine);
        string secondLine = streamReader.ReadLine();
        Console.WriteLine("Secon line: " + secondLine);

        string line = string.Empty;

        while((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }



    }



}
catch (Exception ex)
{

    Console.WriteLine("Error reading in file. Error:" + ex.Message);
}