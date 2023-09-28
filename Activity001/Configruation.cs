using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity001
{
    public class Configruation
    {
        public static IConfiguration Instance => BuildConfigurations();
        private static IConfiguration BuildConfigurations ()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).Build ();
            return configuration;
        } 
    }
}
