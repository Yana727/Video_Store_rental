using System;
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
    public class RentalRecordModel
    {
        [Key]
        public int RentalID { get; set; }
        [ForeignKey("MovieID")]
        public int MovieID { get; set; }
        public MovieModel MovieModel { get; set; }
        [ForeignKey("CustomerID")] //above of what it connects to
        public int CustomerID { get; set; }
        public CustomerModel CustomerModel { get; set; }//connects to customers
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }

        public DateTime ReturnDate { get; set; }
        public void Rented()
        {
            
        }
    }
}