using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreUI.Web.Infra
{
    public interface IPdfMergeData
    {
        IDictionary<string, string> MergeFieldValues { get; }
    }
}
