using Labb3.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.DTOs
{
    public class InterestToAddDto
    {
        [Required] public int PersonId { get; set; }
        [Required, MaxLength(25), MinLength(2)] public string Title { get; set; }
        [Required, MaxLength(25), MinLength(2)] public string Description { get; set; }
        [Required, MaxLength(25), MinLength(2)] public string Url { get; set; }


    }
}
