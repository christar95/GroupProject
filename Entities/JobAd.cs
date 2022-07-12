using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class JobAd
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public int? Salary { get; set; }
        public JobType Type { get; set; }
        public WorkPlace WorkPlace { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
