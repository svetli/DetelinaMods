using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DetelinaReportCost
{
    class WorkTimeConfigSection : ConfigurationSection
    {
        public WorkTimeConfigSection() { }

        [ConfigurationProperty("TimeCollection")]
        public ConfigElementCollection allValues
        {
            get
            {
                return this["TimeCollection"] as ConfigElementCollection;
            }
        }

        public static WorkTimeConfigSection GetConfigSection()
        {
            return ConfigurationManager.GetSection("WorkTimeSection") as WorkTimeConfigSection;
        }
    }
}
