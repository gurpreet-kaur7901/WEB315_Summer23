using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animal.Models
{
    public class Info
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(10)]
        public string Color { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(30)]
        [Required]
        public string Breed { get; set; }
        [RegularExpression(@"^[F/M]")]
        [StringLength(1)]
        [Required]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime Age { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]

        public string Rating { get; set; }
    

        /*public int Rating { get; set;}
        public string RelatedFilms {get; set;}*/
    }
}
//dotnet-aspnet-codegenerator razorpage -m Info -dc AnimalContext -udl -outDir Pages/Infos --referenceScriptLibraries -sqlite