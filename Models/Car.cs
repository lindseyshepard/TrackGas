using System;
using System.ComponentModel.DataAnnotations;

namespace MilesPerGallon.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CarModel { get; set; }
        public float MilesDriven { get; set; }
        public float GallonsFilled { get; set; }




        [DataType(DataType.Date)]
        public DateTime FillupDate { get; set; }


    }
}
