using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightBulbBackend.Models
{
    public class Results
    {
        public Results()
        {
            NumberOfBulbsOn = 0;
            BulbNumbers = null;
        }
        public int NumberOfBulbsOn { get; set; }
        public List<int> BulbNumbers { get; set; }
    }
}
