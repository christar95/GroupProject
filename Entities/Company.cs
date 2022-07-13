using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Employees { get; set; }
        public List<double> Reviews { get; set; }
        public ICollection<JobAd> JobAds { get; set; }
        public Company()
        {
            JobAds=new HashSet<JobAd>();
        }

        

    }
}
