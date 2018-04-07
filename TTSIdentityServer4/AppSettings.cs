using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTSIdentityServer4
{
    public class AppSettings
    {
        public string MvcClient { get; set; }
        public string Api { get; set; }
        public bool UseCustomizationData { get; set; }
    }
}
