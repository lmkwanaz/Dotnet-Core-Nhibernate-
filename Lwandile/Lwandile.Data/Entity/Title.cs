using System;
using System.Collections.Generic;
using System.Text;

namespace Lwandile.Data.Entity
{
    public class Title
    {
        public virtual int TitleID { get; set; }
        public virtual string NameOfSong { get; set; }
        public virtual string Features { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
    }
}
