using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApplication
{
   public class Movie
    {
        public string MovieName { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

       
        public Movie(string name, string actor, string genre, string director)
        {
            this.MovieName = name;
            this.MainActor = actor;
            this.Genre = genre;
            this.Director = director;
        }
        

    }
}
