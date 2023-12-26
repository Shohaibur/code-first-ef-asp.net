using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace code_first_ef_asp.net.EF.Models
{
    public class Users
    {
        [Key]
        [StringLength(20)]
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}