using System;
using System.ComponentModel.DataAnnotations;

namespace ASCT_Razor_Page.Models
{
    public class Aircraft
    {
        [Required(ErrorMessage = "Tail Number is required.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Invalid Tail Number.")]
        public string Tail_Number { get; set; }

        public string LRU_Name { get; set; }

        public string LRU_Part_Number { get; set; }

        public string Software_Name { get; set; }

        public string Software_Part_Number { get; set; }

        public string EC_Number { get; set; }

        public string Pre_Post_Condition { get; set; }

        public Aircraft()
        {
        }
    }
}
