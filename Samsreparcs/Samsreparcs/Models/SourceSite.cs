using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samsreparcs.Models
{
    public class SourceSite
    {
        public int sourceSiteID { get; set; }
        public string scheme { get; set; }
        public string host { get; set; }
        public string path { get; set; } 
        public string queryString { get; set; }

    }
}
