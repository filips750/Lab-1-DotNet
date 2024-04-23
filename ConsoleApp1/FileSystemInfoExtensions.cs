public static class FileSystemInfoExtensions
{
    public static string GetDosAttributes(this FileSystemInfo fileSystemInfo)
    {
        // Konwersja atrybutów na 4-znakowy napis
        string attributes = "";

        if ((fileSystemInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            attributes += "r";
        else
            attributes += "-";

        if ((fileSystemInfo.Attributes & FileAttributes.Archive) == FileAttributes.Archive)
            attributes += "a";
        else
            attributes += "-";

        if ((fileSystemInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            attributes += "h";
        else
            attributes += "-";

        if ((fileSystemInfo.Attributes & FileAttributes.System) == FileAttributes.System)
            attributes += "s";
        else
            attributes += "-";

        return attributes;
    }
}