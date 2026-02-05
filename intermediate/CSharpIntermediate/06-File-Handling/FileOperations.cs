// ===============================
// FILE HANDLING IN C# - SINGLE FILE DEMO
// Covers:
// 1. File class (Read / Write / Append)
// 2. Directory class
// 3. StreamWriter / StreamReader
// 4. Using statement (best practice)
// 5. File.Exists & Directory.Exists
// 6. Path handling
// ===============================


//Do not try to run this code,u need separate files and folders to run this code, also you need to create a folder named "Data" in the same directory as your executable to avoid errors.

//using System;
//using System.IO;

//class FileHandlingDemo
//{
//    static void Main()
//    {
//        // -------------------------------
//        // 1. PATH HANDLING (Best Practice)
//        // -------------------------------
//        // Combines folder + file name safely (cross-platform)
//        string folderPath = "Data";
//        string filePath = Path.Combine(folderPath, "users.txt");

//        // -------------------------------
//        // 2. DIRECTORY HANDLING
//        // -------------------------------
//        // Create directory if it does not exist
//        if (!Directory.Exists(folderPath))
//        {
//            Directory.CreateDirectory(folderPath);
//            Console.WriteLine("Directory created");
//        }

//        // -------------------------------
//        // 3. FILE WRITE (OVERWRITE)
//        // -------------------------------
//        // WriteAllText creates file or overwrites existing content
//        File.WriteAllText(filePath, "User Data File\n");
//        Console.WriteLine("File created and initial data written");

//        // -------------------------------
//        // 4. FILE APPEND (LOG STYLE)
//        // -------------------------------
//        // AppendAllText adds data without deleting old content
//        File.AppendAllText(filePath, "Name: Aryan, Age: 21\n");
//        File.AppendAllText(filePath, "Name: Rahul, Age: 22\n");
//        Console.WriteLine("User data appended");

//        // -------------------------------
//        // 5. FILE EXISTS CHECK
//        // -------------------------------
//        if (File.Exists(filePath))
//        {
//            Console.WriteLine("File exists, ready to read");
//        }

//        // -------------------------------
//        // 6. STREAMWRITER (ADVANCED WRITE)
//        // -------------------------------
//        // Using block ensures file is closed automatically
//        using (StreamWriter writer = new StreamWriter(filePath, true))
//        {
//            writer.WriteLine("Name: Aryan, Age: 20");
//            writer.WriteLine("Data added using StreamWriter");
//        }
//        Console.WriteLine("Data written using StreamWriter");

//        // -------------------------------
//        // 7. STREAMREADER (READ FILE)
//        // -------------------------------
//        using (StreamReader reader = new StreamReader(filePath))
//        {
//            string content = reader.ReadToEnd();
//            Console.WriteLine("\n----- FILE CONTENT START -----");
//            Console.WriteLine(content);
//            Console.WriteLine("----- FILE CONTENT END -----");
//        }

//        // -------------------------------
//        // 8. FILESTREAM (LOW-LEVEL DEMO)
//        // -------------------------------
//        // Used for large files, binary data, uploads
//        using (FileStream fs = new FileStream(
//            Path.Combine(folderPath, "binary.dat"),
//            FileMode.Create,
//            FileAccess.Write))
//        {
//            byte[] data = { 1, 2, 3, 4, 5 };
//            fs.Write(data, 0, data.Length);
//        }
//        Console.WriteLine("Binary file written using FileStream");

//        // -------------------------------
//        // END
//        // -------------------------------
//        Console.WriteLine("\nFile handling demo completed successfully");
//    }
//}
