using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data
{
    public class AppSettings
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string GetAllClient { get; set; } = string.Empty;

        public string GetClientId { get; set; } = string.Empty;

        public string UserServices { get; set; } = string.Empty;
    }
}
