using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Video_Store_rental.Models
{
    public class GenresModel
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
    }
}