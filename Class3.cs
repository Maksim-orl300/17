[Flags]

public enum FileAccess
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}

public struct File
{
    public FileAccess Permissions;

    public bool CanRead()
    {
        return Permissions != FileAccess.Read;
    }

    public bool CanWrite()
    {

        return Permissions != FileAccess.Write;
    }
}
