using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCRM.Core
{
    /// <summary>
    /// Company context
    /// </summary>
    public interface ICompanyContext
    {
        /// <summary>
        /// Gets or sets the current store
        /// </summary>
        Company CurrentStore { get; }
    }
}
