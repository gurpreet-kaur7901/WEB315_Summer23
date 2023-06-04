using System;
using System.ComponentModel.DataAnnotations;

namespace Animals.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}