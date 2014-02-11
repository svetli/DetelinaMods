using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DetelinaReportCost
{
    class ConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("StartTime", IsRequired = true)]
        public string StartTime
        {
            get
            {
                return this["StartTime"] as string;
            }
        }

        [ConfigurationProperty("EndTime", IsRequired = true)]
        public string EndTime
        {
            get
            {
                return this["EndTime"] as string;
            }
        }

        [ConfigurationProperty("Label", IsRequired = true)]
        public string Label
        {
            get
            {
                return this["Label"] as string;
            }
        }
    }
}
