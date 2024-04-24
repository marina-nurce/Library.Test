using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test
{
    class Publication:EntityBase
    {
        public int PublicationYear { get; set; }
        public string Publisher { get; set; }
        public string Edition { get; set; }
    }
}
