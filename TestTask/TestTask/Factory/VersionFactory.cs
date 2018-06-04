using System.Collections.Generic;
using TestTask.Model;

namespace TestTask.Factory
{
    public static class VersionFactory
    {
        public static void CreateVersions()
        {
            var versions = new List<AndroidVersion>
            {
                new AndroidVersion
                {
                    ID = 1,
                    VersionValue = "1.5",
                    VersionName = "Cupcake",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/4/4b/Cupcake.jpg/300px-Cupcake.jpg"
                },

                new AndroidVersion
                {
                    ID = 2,
                    VersionValue = "1.6",
                    VersionName = "Donut",
                    ImageURL = "https://www.droidwiki.org/w/images/0/02/Donut.jpg"
                },
                new AndroidVersion
                {
                    ID = 3,
                    VersionValue = "2.1",
                    VersionName = "Eclair",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/a/af/Eclair.jpg/300px-Eclair.jpg"
                },
                new AndroidVersion
                {
                    ID = 4,
                    VersionValue = "2.2",
                    VersionName = "Froyo",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/7/73/Froyo.jpg/300px-Froyo.jpg"
                },
                new AndroidVersion
                {
                    ID = 5,
                    VersionValue = "2.3",
                    VersionName = "Gingerbread",
                    ImageURL = "https://www.droidwiki.org/w/images/d/d6/Google-android-gingerbread.jpg"
                },
                new AndroidVersion
                {
                    ID = 6,
                    VersionValue = "3.0",
                    VersionName = "Honeycomb",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/4/45/Honeycomb.jpg/300px-Honeycomb.jpg"
                },
                new AndroidVersion
                {
                    ID = 7,
                    VersionValue = "4.0",
                    VersionName = "Ice Cream Sandwich",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/6/69/IceCreamSandwich.jpg/300px-IceCreamSandwich.jpg"
                },
                new AndroidVersion
                {
                    ID = 8,
                    VersionValue = "4.1 - 4.3",
                    VersionName = "Jelly Bean",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/9/93/Jelly_Bean.jpg/300px-Jelly_Bean.jpg"
                },
                new AndroidVersion
                {
                    ID = 9,
                    VersionValue = "4.4",
                    VersionName = "KitKat",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/d/d8/Kitkat.jpg/300px-Kitkat.jpg"
                },
                new AndroidVersion
                {
                    ID = 10,
                    VersionValue = "5.0 = 5.1.1",
                    VersionName = "Lollipop",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/3/38/Lollipop_logo.png/300px-Lollipop_logo.png"
                },
                new AndroidVersion
                {
                    ID = 11,
                    VersionValue = "6.0",
                    VersionName = "Marshmallow",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/4/4c/Android_Marshmallow.png/300px-Android_Marshmallow.png"
                },
                new AndroidVersion
                {
                    ID = 12,
                    VersionValue = "Android 7, also called Android N",
                    VersionName = "Nougat",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Android_7.0_Nougat.jpg/300px-Android_7.0_Nougat.jpg"
                },
                new AndroidVersion
                {
                    ID = 13,
                    VersionValue = "Android 8, also called Android O",
                    VersionName = "Oreo",
                    ImageURL = "https://www.droidwiki.org/w/images/thumb/e/e9/Android_8.0_Oreo.jpg/300px-Android_8.0_Oreo.jpg"
                },
            };

            foreach (var item in versions)
            {
                App.Repository.Create(item);
            }



        }
    }
}
