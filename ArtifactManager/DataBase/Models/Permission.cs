using System;
using System.Data.Entity;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.DataBase.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        
        public int? CategoryId { get; set; }

        public bool Add { get; set; }
        public bool Delete { get; set; }
        public bool Edit { get; set; }
        
        public bool MakeInstance { get; set; }
        public bool KillInstance { get; set; }

        public override string ToString()
        {
            String toRet = "";
            
            if (CategoryId == null)
            {
                toRet += "All - ";
            } else
            {
                using (var db = new DbCtx())
                {
                    toRet += db.GetCategory(CategoryId.Value).Name + " - " ;
                }
            }

            if (Add)
            {
                toRet += "[Add Category]";
            }
            
            if (Delete)
            {
                toRet += "[Delete Category]";
            }
            
            if (Edit)
            {
                toRet += "[Edit Category]";
            }
            
            if (MakeInstance)
            {
                toRet += "[Make Instance]";
            }
            
            if (KillInstance)
            {
                toRet += "[Kill Instance]";
            }

            return toRet;
        }
    }
}