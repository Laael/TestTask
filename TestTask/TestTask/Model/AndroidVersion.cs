using SQLite;

namespace TestTask.Model
{
    [Table("AndroidVersions")]
    public class AndroidVersion
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID 
        {
            get;
            set;
        }
        public string VersionValue 
        {
            get;
            set;
        }
        public string VersionName 
        {
            get;
            set;
        }
        public string ImageURL
        { 
            get;
            set;
        }
        public string Version 
        { 
            get 
            { 
                return $"{VersionName} ({VersionValue})";
            } 
        }
    }

   

}
