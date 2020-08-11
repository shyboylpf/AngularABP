using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Application.Editions;
using Abp.Application.Features;
using LiusStore.Editions;
using System.Linq.Dynamic.Core;
using LiusStore.Tasks;

namespace LiusStore.EntityFrameworkCore.Seed.Host
{
    public class PersonCreator
    {
        private readonly LiusStoreDbContext _context;

        public PersonCreator(LiusStoreDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreatePeople();
        }

        private void CreatePeople()
        {
            if (_context.People.IgnoreQueryFilters().Count() == 0)
            {
                _context.People.AddRange(
                    new Person { Name = "Isaac Asimov" },
                    new Person { Name = "Thomas More" },
                    new Person { Name = "George Orwell" },
                    new Person { Name = "Douglas Adams" }
                    );
                _context.SaveChanges();
            }
        }
    }
}