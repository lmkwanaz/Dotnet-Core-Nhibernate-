using System;
using System.Collections.Generic;
using System.Text;

namespace Lwandile.Data.Entity
{
    public class Artist
    {
        public virtual int ArtistID { get; set; }
        public virtual string OriginalName { get; set; }
        public virtual int Age { get; set; }
    }
}
