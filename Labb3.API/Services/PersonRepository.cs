using Labb3.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Services
{
    public class PersonRepository : IPersonRepository
    {
        private UserDbContext _context;

        public PersonRepository(UserDbContext context)
        {
            _context = context;
        }

        public Link AddLinkForOneSpecificPerson(Link newLink)
        {
            var result = _context.Links.Add(newLink);
            _context.SaveChanges();
            return result.Entity;
        }

        public Interest AttachInterest(Interest newInterest)
        {
            var interest = _context.Interests.Add(newInterest);
            _context.SaveChanges();
            return interest.Entity;
        }

        public Link AttachLink(Link newLink)
        {

            var result = _context.Links.Add(newLink);
            _context.SaveChanges();
            return result.Entity;
        }

        public List<Person> GetAllPersons()
        {
            _context.Interests.Include(x => x.Links).ToArray();
            return _context.Persons.ToList();
        }



        public List<Link> GetLink(int Id)
        {


            _context.Interests.ToArray();
            _context.Links.ToArray();

            var linkz = _context.Persons.Where(x => x.Id == Id).FirstOrDefault().Interests.SelectMany(x => x.Links).ToList();



            return linkz;

        }

        public List<Person> GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Interest> GetPersonInterest(int id)
        {
            _context.Interests.Include(x => x.Links).ToArray();
            return _context.Interests.Where(x => x.Id == id).ToList();
        }

        public Person GetSinglePerson(int id)
        {
            _context.Interests.Include(x => x.Links).ToArray();
            return _context.Persons.FirstOrDefault(x => x.Id == id);
        }
    }
}
