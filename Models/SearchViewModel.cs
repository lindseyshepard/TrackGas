using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MilesPerGallon.Models
{
    public class SearchViewModel
    {
        public List<Car> Cars { get; set; }
        public SelectList FirstName { get; set; }
        public string CarModel { get; set; }
        public string SearchString { get; set; }
    }
}
