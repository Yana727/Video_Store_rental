using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Video_Store_rental
{
    public class RentalRecordModel
    {
        [Key]
        public int RentalID {get; set;}
        [ForeignKey("MovieID")]
        public int MovieID { get; set; }
        [ForeignKey("CustomerID")] //above of what it connects to
        public int CustomerID { get; set; }
        public CustomerModel CustomerModel {get; set; }//connects to customers
        public DateTime RentalDate {get; set;} 
        public DateTime DueDate { get; set; }

        public DateTime ReturnDate {get; set;}

}