using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Models
{
    public class Person
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int PhoneNumber { get; set; }


        public IList<Interest> Interests { get; set; }


    }
}
