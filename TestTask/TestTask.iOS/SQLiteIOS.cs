using System;
using Xamarin.Forms;
using System.IO;
using TestTask.iOS;

[assembly: Dependency(typeof(SQLiteIOS))]
namespace TestTask.iOS
{
    
    public class SQLiteIOS : ISQLite
    {
        public SQLiteIOS() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            // определяем путь к бд
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // папка библиотеки
            var path = Path.Combine(libraryPath, sqliteFilename);

            return path;
        }
    }
}
