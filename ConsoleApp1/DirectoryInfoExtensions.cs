public static class DirectoryInfoExtensions
{
    public static DateTime GetOldestFileDateRecursive(this DirectoryInfo directory)
    {
        DateTime oldestDate = DateTime.MaxValue;

        foreach (var file in directory.GetFiles())
        {
            if (file.LastWriteTime < oldestDate)
            {
                oldestDate = file.LastWriteTime;
            }
        }

        foreach (var subDirectory in directory.GetDirectories())
        {
            DateTime subDirOldestDate = GetOldestFileDateRecursive(subDirectory);
            if (subDirOldestDate < oldestDate)
            {
                oldestDate = subDirOldestDate;
            }
        }

        return oldestDate;
    }
}
