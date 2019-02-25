using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Your name is required")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(100, ErrorMessage = "Only 100 characters can be written in this message box")]
        public string Message { get; set; }
        public bool Contact { get; set; }
    }
}
