using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class BaseFileOperations
{
    // directoryName Summary:
    //     This is the name of the directory.
    //
    // Returns:
    //     A returns the directory name
    public virtual string directoryName()
    {
        return "Default Directory";
    }

    // doesDirExist Summary:
    //     Checks if the directory has been created.
    //
    // Returns:
    //     A returns a true or false value
    public bool doesDirExist()
    {
        return Directory.Exists(this.directoryPath());
    }

    // doesFileExist Summary:
    //     Checks if the file exists in the directory.
    //
    // Returns:
    //     A returns a true or false value
    public bool doesFileExist(string fileName)
    {
        return File.Exists($"{this.directoryPath()}\\{fileName}");
    }

    // directoryPath Summary:
    //     Gets the directory that the file will be copied into.
    //
    // Returns:
    //     A returns the directory path
    public string directoryPath()
    {
        return $"{this.basePath()}\\{this.directoryName()}";
    }

    // basePath Summary:
    //     Gets the directory path that the application is currently in.
    //
    // Returns:
    //     A returns the directory path
    public string basePath()
    {
        return Directory.GetCurrentDirectory();
    }
    // writeFile Summary:
    //     Creates a file that writes UTF-8 encoded text to an existing
    //     file, or to a new file if the specified file does not exist.
    //
    // Parameters:
    //   requestData:
    //     This request data contains attributes called the fileName which can be used for identifying the file that should be deleted.
    //
    //   data:
    //     The data that should be inserted into the file
    //
    // Returns:
    //     A success message after the file has been created successfully
    public string writeFile(RequestData requestData, string data)
    {
        string fileName =  requestData.fileName;
        if (this.doesDirExist())
        {
            File.WriteAllText($"{this.directoryPath()}/{fileName}.txt", data);
            return "Success";
        }
        else 
        {
            Directory.CreateDirectory(this.directoryPath());
            return $"{this.directoryPath()} Folder Does not exist";
        }
        
    }

   
    // deleteFile Summary:
    //     Creates a System.IO.StreamWriter that appends UTF-8 encoded text to an existing
    //     file, or to a new file if the specified file does not exist.
    //
    // Parameters:
    //   requestData:
    //     This request data contains attributes called the fileName which can be used for identifying the file that should be deleted.
    //
    // Returns:
    //     A stream writer that appends UTF-8 encoded text to the specified file or to a
    //     new file.
    //
    public string deleteFile(RequestData requestData)
    {
        string fileName = requestData.fileName;
        if (this.doesFileExist(fileName))
        {
            File.Delete($"{this.directoryPath()}/{fileName}.txt");
            return "Success";
        }
        else
        {
            return "File does not exist";
        }
        
    }

    // readFile Summary:
    //     Reads a file in UTF-8 encoded text 
    //
    // Parameters:
    //   requestData:
    //     This request data contains attributes called the fileName which can be used for identifying the file that should be deleted.
    //
    // Returns:
    //      Uhe data in a UTF-8 encoded text format
    //
    public string readFile(RequestData requestData)
    {
        string fileName = requestData.fileName;
        return File.ReadAllText($"{this.basePath()}/{fileName}.txt");
    }





}


