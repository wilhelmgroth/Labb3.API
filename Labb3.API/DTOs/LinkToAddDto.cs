using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.DTOs
{
    public class LinkToAddDto
    {
        [Required] public int InterestId { get; set; }

        [Required, MinLength(2), MaxLength(25)] public string Url { get; set; }



    }
}
