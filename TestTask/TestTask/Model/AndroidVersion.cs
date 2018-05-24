using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;

namespace TestTask.Model
{
    [Table("AndroidVersions")]
    public class AndroidVersion
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public string _version { get; set; }
        public string _versionName { get; set; }
        public string imageURL { get; set; }
        public string version { get { return $"{_versionName} ({_version})"; } }
    }

    public static class VersionFactory 
    {
        public static void CreateVersions()
        {
            var versions = new ObservableCollection<AndroidVersion>
            {
                new AndroidVersion
                {
                    id = 1,
                    _version = "1.5",
                    _versionName = "Cupcake",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/4/4b/Cupcake.jpg/300px-Cupcake.jpg"
                },

                new AndroidVersion
                {
                    id = 2,
                    _version = "1.6",
                    _versionName = "Donut",
                    imageURL = "https://www.droidwiki.org/w/images/0/02/Donut.jpg"
                },
                new AndroidVersion
                {
                    id = 3,
                    _version = "2.1",
                    _versionName = "Eclair",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/a/af/Eclair.jpg/300px-Eclair.jpg"
                },
                new AndroidVersion
                {
                    id = 4,
                    _version = "2.2",
                    _versionName = "Froyo",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/7/73/Froyo.jpg/300px-Froyo.jpg"
                },
                new AndroidVersion
                {
                    id = 5,
                    _version = "2.3",
                    _versionName = "Gingerbread",
                    imageURL = "https://www.droidwiki.org/w/images/d/d6/Google-android-gingerbread.jpg"
                },
                new AndroidVersion
                {
                    id = 6,
                    _version = "3.0",
                    _versionName = "Honeycomb",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/4/45/Honeycomb.jpg/300px-Honeycomb.jpg"
                },
                new AndroidVersion
                {
                    id = 7,
                    _version = "4.0",
                    _versionName = "Ice Cream Sandwich",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/6/69/IceCreamSandwich.jpg/300px-IceCreamSandwich.jpg"
                },
                new AndroidVersion
                {
                    id = 8,
                    _version = "4.1 - 4.3",
                    _versionName = "Jelly Bean",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/9/93/Jelly_Bean.jpg/300px-Jelly_Bean.jpg"
                },
                new AndroidVersion
                {
                    id = 9,
                    _version = "4.4",
                    _versionName = "KitKat",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/d/d8/Kitkat.jpg/300px-Kitkat.jpg"
                },
                new AndroidVersion
                {
                    id = 10,
                    _version = "5.0 = 5.1.1",
                    _versionName = "Lollipop",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/3/38/Lollipop_logo.png/300px-Lollipop_logo.png"
                },
                new AndroidVersion
                {
                    id = 11,
                    _version = "6.0",
                    _versionName = "Marshmallow",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/4/4c/Android_Marshmallow.png/300px-Android_Marshmallow.png"
                },
                new AndroidVersion
                {
                    id = 12,
                    _version = "Android 7, also called Android N",
                    _versionName = "Nougat",
                    imageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Android_7.0_Nougat.jpg/300px-Android_7.0_Nougat.jpg"
                },
                new AndroidVersion
                {
                    id = 13,
                    _version = "Android 8, also called Android O",
                    _versionName = "Oreo",
                    imageURL = "https://www.droidwiki.org/w/images/thumb/e/e9/Android_8.0_Oreo.jpg/300px-Android_8.0_Oreo.jpg"
                },
            };

            foreach (var item in versions)
            {
                App.Repository.Create(item);
            }



        }
    }

}
