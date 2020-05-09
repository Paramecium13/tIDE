using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace xTile.Format
{
    [Serializable]
    public class CompatibilityResults
    {
        private List<string> m_remarks;

        public CompatibilityResults(CompatibilityLevel compatibilityLevel, List<string> remarks)
        {
            CompatibilityLevel = compatibilityLevel;
            m_remarks = new List<string>(remarks);
        }

        public CompatibilityResults(CompatibilityLevel compatibilityLevel)
        {
            CompatibilityLevel = compatibilityLevel;
            m_remarks = new List<string>();
        }

        public CompatibilityLevel CompatibilityLevel { get; }

        public ReadOnlyCollection<string> Remarks => m_remarks.AsReadOnly();
    }
}
