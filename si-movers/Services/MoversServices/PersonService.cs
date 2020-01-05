using Bogus;
using Microsoft.Extensions.DependencyInjection;
using si_movers.Services.IMoversServices;
using System;

namespace si_movers.Services.MoversServices
{
    public class PersonService : IPersonService
    {
        private IGenerateData _generateData;
        private MoversDbContext _context;
       
        public PersonService(IGenerateData generateData)
        {
            _generateData = generateData;
            _context = new MoversDbContext();
        }

        void IPersonService.AddPerson(int recordNo)
        {
            var person = _generateData.GeneratePerson(recordNo);

            _context.Add(person);
            _context.SaveChanges();
        }
    }
}
