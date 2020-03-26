using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } //Required by DB for primary key
        public string Title { get; set; }

        [Display(Name = "Release Date")] //Changes ReleaseDate to be displayed as "Release Date on the DB page in the app
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } //DataType specifies the type of data i.e. Date
        public string Genre { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
