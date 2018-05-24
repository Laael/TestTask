using System;
namespace TestTask
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
