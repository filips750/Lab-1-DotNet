namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    internal class Program
    {
        static void Main(string[] args)
        {
            String filePath = args[0];
            ListFiles.listFiles(filePath, 0); // fixed filepath

            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            DateTime oldestFileDate = directoryInfo.GetOldestFileDateRecursive();
            Console.WriteLine($"Najstarsza data modyfikacji pliku: {oldestFileDate}");

            // Przykład użycia metody rozszerzającej dla FileSystemInfo
            String[] filesInDirectory = Directory.GetFiles(filePath);
            FileInfo fileInfo = new FileInfo(filesInDirectory[0]);
            string dosAttributes = fileInfo.GetDosAttributes();
            Console.WriteLine($"Atrybuty DOS: {dosAttributes}");
        }
    }
}
