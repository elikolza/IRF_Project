using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokcz
{
    class Filter
    {
        private string occupation;

        public Filter(string occupation)
        {
            this.occupation = occupation;
        }

        public string Occupation
        {
            get { return occupation; }
        }
    }

}
