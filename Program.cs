using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        //StreamWriter
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