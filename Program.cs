using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        //Path
        string path = @"C:\Windows\Temp\file1.txt";

        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
        Console.WriteLine("PathSeparator: " + Path.PathSeparator);
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
        Console.WriteLine("GetFileName: " + Path.GetFileName(path));
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("GetExtension: " + Path.GetExtension(path));
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
        Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        // Directory, DirectoryInfo
        /*
        string path = @"C:\Windows\Temp\myFolder";
        try
        {
            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS: ");
            foreach (string item in folders)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------");
            //------------------------------------------------------
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES: ");
            foreach (string item in files)
            {
                Console.WriteLine(item);
            }
            //------------------------------------------------------
            Console.WriteLine("------------------------------------------------------");
            Directory.CreateDirectory(path + @"\newfolder");
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.ToString());
        }
        */
        //StreamWriter
        /*
        string sourcePath = @"C:\Windows\Temp\file1.txt";
        string targetPath = @"C:\Windows\Temp\file2.txt";
        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }

            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.ToString());
        }
        */

        //Bloco using
        /*
        string path = @"C:\Windows\Temp\file1.txt";
        try
        {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.ToString());
        }


        */


        // FileStream e StreamReader
        /*
        string path = @"C:\Windows\Temp\file1.txt";
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
        }
        */




        //File, FileInfo e IOException
        /*
        string sourcePath = @"C:\Windows\Temp\file1.txt";
        string targetPath = @"C:\Windows\Temp\file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
        */
    }
}