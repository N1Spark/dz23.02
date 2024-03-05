using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_23._02.Model
{
    class CountryDataContext : DataContext
    {
        public CountryDataContext() :
            base(ConfigurationManager.ConnectionStrings["CountryDB"].ConnectionString)
        { }

        public Table<Country_Model> Countries => GetTable<Country_Model>();
    }
}
