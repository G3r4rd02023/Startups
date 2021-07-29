using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Startups.Data.Entities
{
    public class CompanyUser
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string UserId { get; set; }

        public Company Company { get; set; }

        public User User { get; set; }

    }
}
