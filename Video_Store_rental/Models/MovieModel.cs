using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Video_Store_rental
{
    public class MovieModel
    {   
        [Key]
        public int MovieID { get; set; }   
        public string MovieName { get; set; }   
        public string MovieDescription { get; set; }    
        [ForeignKey("GenreID")]
        public int GenreID { get; set; }
    }
}