using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [StringLength(350)]
        public string MovieTitle { get; set; }
        public int MovieId { get; set; }

        [StringLength(250)]
        public string MovieDirector { get; set; }
        [StringLength(250)]
        public string MovieCountry { get; set; }
        [StringLength(150)]
        public string MovieCategory { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime RequiredDate { get; set; }
    }
}
