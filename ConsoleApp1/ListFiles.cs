public static class ListFiles
{
    public static void listFiles(String filePath, int depth)
    {
        string[] filePaths = Directory.GetFiles(filePath);
        string[] directoryPaths = Directory.GetDirectories(filePath);
        foreach(var file in filePaths){
            Console.WriteLine(String.Concat(Enumerable.Repeat(" ", depth)) + file);
            FileInfo fileInfo = new FileInfo(file);
            Console.WriteLine(fileInfo.Length.ToString());
            Console.WriteLine(fileInfo.GetDosAttributes());
        }
        foreach (var directory in directoryPaths)
        {
            Console.WriteLine(String.Concat(Enumerable.Repeat(" ", depth)) + directory);
            Console.WriteLine(Directory.GetFiles(directory).Length);
            listFiles(directory, depth + 1);
        }
    }
}