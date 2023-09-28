using EFCore_DbLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity001
{
    public class TestDbConnectivity
    {
        private static DbContextOptionsBuilder<AdventureWorks2019Context> _optionsBuilder;

        static TestDbConnectivity()
        {

            _optionsBuilder = new DbContextOptionsBuilder<AdventureWorks2019Context>();
            _optionsBuilder.UseSqlServer(Configruation.Instance.GetConnectionString("DefaultConnection"));
        }


        public void DisplayFirstPerson()
        {
            using AdventureWorks2019Context db = new AdventureWorks2019Context(_optionsBuilder.Options);
            var person = db.People.FirstOrDefault();
            
            Console.WriteLine(person);
        }
    }
}
