using System;
using System.Collections.Generic;
using System.Text;

namespace Lwandile.Data.Entity
{
   public  class Library
    {
        public virtual int ArtistID { get; set; }
        public virtual int TitleID { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
