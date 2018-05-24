using System;
using System.Collections.Generic;
using TestTask.Model;
using System.Linq;

namespace TestTask.Repository
{
    public class DescriptionRepository
    {

        List<Description> descriptions;

        public DescriptionRepository()
        {
            descriptions = DescriptionFactory.GetDescription();
        }

        public AndroidVersion GetVersionById(int index)
        {
         
            return App.Repository.GetItems().SingleOrDefault(x => (x).id == index);
           
        }

        public Description GetDescriptionsByVersion(int versionId)
        {
            return descriptions.SingleOrDefault(x => x.version.id == versionId);
        }
    }
}
