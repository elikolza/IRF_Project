using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokcz.Entities
{
    public class Education
    {
        public int StartYear { get; set; }
        public Gender Gender { get; set; }
        public int NbrOfTerms { get; set; }
        public bool IsPupil { get; set; }
        public Education ()
        {
            IsPupil = true;
        }
    }
}
 