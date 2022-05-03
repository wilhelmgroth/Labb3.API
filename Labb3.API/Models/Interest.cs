using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Models
{
    public class Interest
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public IList<Link> Links { get; set; }

        public int PersonId { get; set; }



    }
}
