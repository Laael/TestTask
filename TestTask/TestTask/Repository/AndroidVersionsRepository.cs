using System.Collections.Generic;
using SQLite;
using TestTask.Model;
using Xamarin.Forms;
using System;

namespace TestTask
{
    public class AndroidVersionsRepository : IRepository<AndroidVersion>
    {

        static readonly Lazy<AndroidVersionsRepository> lazy = new Lazy<AndroidVersionsRepository>(() => new AndroidVersionsRepository());

        public static AndroidVersionsRepository Current 
        {
            get
            {
                return lazy.Value;
            }
        }

        SQLiteConnection database;
        AndroidVersionsRepository()
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(App.DataBaseName);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<AndroidVersion>();
           
        }

        public List<AndroidVersion> GetItems()
        {
           
            List<AndroidVersion> collection = new List<AndroidVersion>();
            foreach(var item in database.Table<AndroidVersion>())
            {
                collection.Add(item);
            }

            if(collection.Count == 0)
                Factory.VersionFactory.CreateVersions();

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