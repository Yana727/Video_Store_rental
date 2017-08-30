using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Video_Store_rental.Models
{
    public class CustomerModel
    {  
        [Key]
        public int CustomerID { get; set; } 
        public string  CustomerName { get; set; }

        public int CustomerPhone { get; set; }
    }
}