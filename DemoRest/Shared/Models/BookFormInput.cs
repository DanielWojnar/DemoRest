using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRest.Model.Models
{
    public class BookFormInput
    {
        [Required]
        [StringLength(120, MinimumLength = 2, ErrorMessage = "Title need to be bettwen 2 and 120 characters long")]
        public string Title { get; set; }
        [StringLength(256, ErrorMessage = "Description cannot be longer than 256 characters")]
        public string? Description { get; set; }
        [Required]
        [Range(0, 100000, ErrorMessage = "Amount invalid (1-100000).")]
        public int Amount { get; set; }
    }
}
