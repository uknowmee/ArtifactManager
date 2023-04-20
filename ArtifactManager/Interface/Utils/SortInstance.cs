using System;
using System.Collections.Generic;
using System.Linq;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Models.Instances;

namespace ArtifactManager.Interface.Utils

{
    public static class SortInstance
    {
        public static List<Instance> SortedInstancesOfCategory(List<Instance> instances, int instancesNum)
        {
            if (instances.Count == 0)
            {
                return instances;
            }

            using (var db = new DbCtx())
            {
                var categoryId = instances[0].CategoryId;
                try
                {
                    var limitProperty = db.LimitProperty(categoryId);

                    var instanceProperties = db.BasePropertiesNamed(limitProperty.Name);
                    instanceProperties = instanceProperties.OrderByDescending(p => float.Parse(p.Value)).ToList();

                    List<Instance> newInstances = new List<Instance>();

                    foreach (InsBaseProperty instanceProperty in instanceProperties)
                    {
                        newInstances.Add(instances.Single(i => i.InstanceId == instanceProperty.InstanceId));
                    }

                    return newInstances.Take(instancesNum).ToList();
                } catch (Exception e)
                {
                    return instances.Take(instancesNum).ToList();
                }
            }
        }
    }
}