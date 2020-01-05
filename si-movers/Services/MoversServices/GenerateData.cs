using Bogus;
using si_movers.Services.IMoversServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace si_movers.Services.MoversServices
{
    class GenerateData : IGenerateData
    {
        Person IGenerateData.GeneratePerson(int recordNo)
        {
            var PersontoSave = new Person();

            var persons = new Faker<Person>()
                .StrictMode(false)
                .Rules((f, o) =>
                {
                    o.Id = f.Random.Replace("###-###-###-###");
                    o.FirstName = f.Name.FirstName();
                    o.LastName = f.Name.LastName();
                    o.Street = f.Address.StreetName();
                    o.Housenumber = f.Address.BuildingNumber();
                    o.City = f.Address.City();
                });
            var personList = persons.Generate(1);

            foreach (var res in personList)
            {
                PersontoSave.Id = res.Id;
                PersontoSave.FirstName = res.FirstName;
                PersontoSave.LastName = res.LastName;
                PersontoSave.Street = res.Street;
                PersontoSave.Housenumber = res.Housenumber;
                PersontoSave.City = res.City;
            }
            return PersontoSave;
        }
    }
}
