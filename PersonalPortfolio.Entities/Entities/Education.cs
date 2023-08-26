using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Entities.Entities
{
    public class Education
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? University { get; set; }
        public string? Faculty { get; set; }
        public string? Department { get; set; }
    }
}
