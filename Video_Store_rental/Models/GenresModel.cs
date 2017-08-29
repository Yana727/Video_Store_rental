using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Video_Store_rental
{
    public class GenresModel
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
    }
}