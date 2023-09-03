﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Entities.Dtos
{
    public class ExperienceAddDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime FinishDate { get; set; }
    }
}
