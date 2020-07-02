using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BaseLogin.Models
{
    public class LoginDetail
    {


        [Key]
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(60)")]
        public string Password { get; set; }
    }
}
