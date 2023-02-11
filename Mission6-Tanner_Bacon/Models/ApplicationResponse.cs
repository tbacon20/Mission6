using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Tanner_Bacon.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }
        //public static readonly string[] Options = new string[] { "G", "PG", "PG-13", "R"};

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        public int Year  { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [RegularExpression(@"^(G|PG|PG-13|R)$", ErrorMessage =  "Please select a rating")]
        public string Rating { get; set; }

        [RegularExpression(@"^(Yes|No)$", ErrorMessage = "Please select a rating")]
        public string Edited { get; set; }

        public string Lent { get; set; }

        [StringLength(25, ErrorMessage = "The string must be 25 characters or less.")]
        public string Notes { get; set; }

    }
}
