using System;
using System.Collections.Generic;
using System.Linq;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models;
using ArtifactManager.DataBase.Models.Instances;

namespace ArtifactManager.Interface.Utils
{
    public static class CatInsInfo
    {
        public static String LoginCategoryInfo(int categoryId)
        {
            using (var db = new DbCtx())
            {
                Category category = db.GetCategory(categoryId);
                List<Property> properties = db.GetCategoryProperties(categoryId);
                List<BaseProperty> baseProperties = db.GetCategoryBaseProperties(categoryId);

                var info = category.ToString();
                info += "\n\n";
                info += "#Attributes:\n";
                foreach (var property in baseProperties)
                {
                    info += property + "\r\n";
                }
                info += "\n#Elements:\n";
                foreach (var property in properties)
                {
                    info += property + "\r\n";
                }

                return info;
            }
        }

        public static string InstanceInfo(String categoryName, string instanceName)
        {
            using (var db = new DbCtx())
            {
                Instance instance = db.InstancesOfCategory(categoryName).Single(i=>i.Name == instanceName);
                List<InsProperty> properties = db.InsProperties.Where(i=>i.InstanceId == instance.InstanceId).ToList();
                List<InsBaseProperty> baseProperties = db.InsBaseProperties.Where(i=>i.InstanceId == instance.InstanceId).ToList();;
                
                var info = instance.ToString();
                info += "\n\n";
                info += "#Attributes:\n";
                foreach (var property in baseProperties)
                {
                    info +=  property.Type+ " - " + property.Name + " - " + property.Value + "\r\n";
                }
                info += "\n#Elements:\n";
                foreach (var property in properties)
                {
                    Instance tempInstance = db.GetInstance(property.ElementId);
                    if (tempInstance != null)
                    {
                        info +=  db.GetCategory(tempInstance.CategoryId).Name + " " + property.Name +"\r\n";
                    }
                }
                
                return info;
            }
        }
    }
}