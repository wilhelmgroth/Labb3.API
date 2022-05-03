using Labb3.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Services
{
    public interface IPersonRepository
    {

        List<Person> GetAllPersons();
        Person GetSinglePerson(int Id);

        List<Interest> GetPersonInterest(int id);
        List<Link> GetLink(int Id);


        Interest AttachInterest(Interest newInterest);
        Link AttachLink(Link newLink);


        List<Person> GetPersonById(int id);







    }
}
