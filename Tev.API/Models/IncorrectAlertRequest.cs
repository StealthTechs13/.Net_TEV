using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tev.API.Models
{
    public class IncorrectAlertRequest
    {
        [Required]
        public string AlertId { get; set; }
        public string Comment { get; set; }
    }
}
