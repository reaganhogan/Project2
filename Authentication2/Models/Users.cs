using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Authentication2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public int UserEmail { get; set; }
        public string UserPassward { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 

    }
}