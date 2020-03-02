using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage ="Debes escribir un título entre 3 y 60 caracteres"), Required(ErrorMessage = "Debes escribir un título entre 3 y 60 caracteres")]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date, ErrorMessage ="Debes elegir una fecha"), DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required(ErrorMessage ="Debes escribir un género"), StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency), Required(ErrorMessage ="Debes especificar un precio")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; }
    }
}