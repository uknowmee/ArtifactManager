using System;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.DataBase.Models
{
    public class Modified
    {
        public int ModifiedId { get; set; }
        
        public bool Add { get; set; }
        public bool Delete { get; set; }
        public bool Edit { get; set; }
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }

        public override string ToString()
        {
            string info = "";
            if (Add)
            {
                info = " Added ";
            } else if (Delete)
            {
                info = " Deleted ";
            } else if (Edit)
            {
                info = " Edited ";
            }

            String nick;
            using (var db = new DbCtx())
            {
                nick = db.GetUser(UserId).Nick;
            }
            
            return nick + info + CategoryName;
        }
    }
}