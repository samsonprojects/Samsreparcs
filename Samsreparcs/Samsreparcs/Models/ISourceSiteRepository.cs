using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samsreparcs.Models
{
    public interface ISourceSiteRepository
    {
        IQueryable<SourceSite> SourceSites { get; set; }
    }
}
