using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class BaseModel
    {
        public MovieViewModel MovieViewModel { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
        public ShopCartViewModel ShopCartViewModel { get; set; }
        public UserViewModel UserViewModel { get; set; }
        public WishListViewModel WishListViewModel { get; set; }
    }
}
