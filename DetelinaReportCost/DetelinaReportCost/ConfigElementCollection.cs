using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DetelinaReportCost
{
    class ConfigElementCollection : ConfigurationElementCollection
    {
        public ConfigElement this[int index]
        {
            get
            {
                return base.BaseGet(index) as ConfigElement;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConfigElement)(element)).Label;
        }
    }
}
