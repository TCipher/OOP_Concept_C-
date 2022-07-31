using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    //the class cannot be instatianted
    //the class is defined as static because it is a base class 
    //and it is not meant to be used by other classes, it is created for the purpose of inheritance
   public abstract class EntityBase
    {
        public bool IsNew { get; set; }
        public bool HasChanges { get; set; }
        public EntityStateOption  EntityState { get; set; }
        public bool Isvalid
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
      
    }
}
