using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace dz_23._02.Model
{
    [Table(Name = "Country")]
    class Country_Model
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Capital { get; set; }

        [Column]
        public int Population { get; set; }

        [Column]
        public int Area { get; set; }

        [Column]
        public string Continent { get; set; }
    }
}
