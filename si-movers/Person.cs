using System;
using System.ComponentModel.DataAnnotations;

namespace si_movers
{
    public class Person
    {
        public string Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        [StringLength(20)]
        public string Housenumber { get; set; }
        [StringLength(20)]
        public string City { get; set; }
    }
}
