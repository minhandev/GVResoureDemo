using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Utilities
{
    public class Settings
    {
        public const string SectionName = "WebSettings";
        public string webServices { get; set; }
        public string webDashboard { get; set; }
    }
}
