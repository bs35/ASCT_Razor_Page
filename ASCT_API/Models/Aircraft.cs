using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASCT_API.Models
{
    public class Aircraft
    {
        [Required(ErrorMessage = "Tail Number is required.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Invalid Tail Number.")]
        public string Tail_Number { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string LRU_Name { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string LRU_Part_Number { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string Software_Name { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string Software_Part_Number { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string EC_Number { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Pre_Post_Condition { get; set; }

    }
}
