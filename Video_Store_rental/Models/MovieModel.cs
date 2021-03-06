using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Video_Store_rental.Models;


namespace Video_Store_rental.Models
{
    public class MovieModel
    {   
        [Key]
        public int MovieID { get; set; }   
        public string MovieName { get; set; }   
        public string MovieDescription { get; set; } 
       
        [ForeignKey("GenreID")]
        public int GenreID { get; set; }
        public GenresModel GenresModel { get; set; }
    }
}