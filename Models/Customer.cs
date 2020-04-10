using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{[Table("Customer")]
    public class Customer
    {[Key]
        public int CId { get; set; }
        public string CName { get; set; }

        public DateTime CDob{ get; set; }

        [MaxLength(4)]
        public int CPIN{ get; set; }
    }
}
