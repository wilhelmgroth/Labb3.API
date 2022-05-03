using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Models
{
    public class Link
    {

        public int Id { get; set; }

        public string Url { get; set; }


        public int InterestId { get; set; }

    }
}
