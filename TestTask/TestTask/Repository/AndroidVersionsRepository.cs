using System.Collections.Generic;
using System.Linq;
using SQLite;
using TestTask.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TestTask
{

    public interface IRepository<T>
    {
        void Create(AndroidVersion version);
        // Насколько я понимаю, тут правильнее использовать void Create(object version);  для того, чтобы интерфейс был более обобщённым
        void Update(AndroidVersion version);
        void Delete(int id);
        AndroidVersion Get(int id);
        ObservableCollection<AndroidVersion> GetItems();
    }


    public class AndroidVersionsRepository : IRepository<AndroidVersion>
    {
        SQLiteConnection database;
        public AndroidVersionsRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<AndroidVersion>();
           
        }
        public ObservableCollection<AndroidVersion> GetItems()
        {
           
            ObservableCollection<AndroidVersion> collection = new ObservableCollection<AndroidVersion>();
            foreach(var item in database.Table<AndroidVersion>())
            {
                collection.Add(item);
            }

            if(collection.Count == 0)
                VersionFactory.CreateVersions();

            return collection;

        }


        public AndroidVersion Get(int id)
        {
            return database.Get<AndroidVersion>(id);
        }

        public void Update(AndroidVersion version)
        {
            database.Update(version);
        }

        public void Delete(int id)
        {
             database.Delete<AndroidVersion>(id);
        }
        public void Create(AndroidVersion item)
        {
           
            database.Insert(item);

        }
    }
}