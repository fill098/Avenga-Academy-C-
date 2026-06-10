#region Task 1 
//Create a folder named "Files".
//Create a file name "names.txt"


string folderPath = @"..\..\..\Files";
string filePath = Path.Combine(folderPath, "names.txt");

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Folder created!!");
}


if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine("File names.txt created!!");
}



#endregion

#region Task 2
//Read the file created in the previous task named "names.txt"
//Ask the user to enter some names and save these names in the file that we previously created.


Console.WriteLine("Enter names one by one and enter 'done' when finished!!");
Console.WriteLine("Enter a name");



while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "done")
    {
        break;
    }

    if (!string.IsNullOrWhiteSpace(input))
    {
        File.AppendAllText(filePath, input + Environment.NewLine);

        Console.WriteLine($"{input} saved");
    }
    else
    {
        Console.WriteLine("Name can not be empty, Try again.");
    }


}

Console.WriteLine("All names saved");


#endregion

#region Task 3 and 4
//Read the file created in the previous task name "names.txt"
//Go thru the file content and filter out all the names that start with A.
//If there are any names create a new file named "namesStartingWith_A.txt"
//that will contains the filtered content and if there is no names that start with A do nothing.
//Do this for all the letters in the alphabet.

//Redo Task 3 but if the file already exists add the new names in the file and keep the already existing names.

string[] names = File.ReadAllLines(filePath);

Console.WriteLine("Printing file from pc!!");

for (char letter = 'A'; letter <= 'Z'; letter++)
{
    foreach (string name in names)
    {
        if (name.ToUpper().StartsWith(letter))
        {
            string outputFile = Path.Combine(folderPath, $"nameStartsWith_{letter}.txt");

            if (File.Exists(outputFile))
            {
                string[] existingNames = File.ReadAllLines(outputFile);
                if (!Array.Exists(existingNames, n => n == name))
                {
                    File.AppendAllText(outputFile, name + Environment.NewLine);
                }
            }
            else
            {
                File.AppendAllText(outputFile, name + Environment.NewLine);
            }
        }
    }
}


#endregion
