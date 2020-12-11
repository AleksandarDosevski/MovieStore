using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
       
        [StringLength(350)]
        public string Title { get; set; }

        [StringLength(350)]
        public string DirectorName { get; set; }

        public int DirectorID { get; set; }
        public Director Director { get; set; }

        public DateTime YearOfRelease { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
     
        [StringLength(150)]
        public string CategoryName { get; set; }
     
        public double Price { get; set; }
      
        [StringLength(50)]
        public string MovieType { get; set; } // EMovie, AudioMovie, Fisical Movie
      
        public string Description { get; set; }
       
        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(150)]
        public string Country { get; set; }

     
     
        public int Copies { get; set; }
     
        [StringLength(50)]
        public string Shipping { get; set; }

        public string PhotoURL { get; set; }

        public int SoldItems { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
