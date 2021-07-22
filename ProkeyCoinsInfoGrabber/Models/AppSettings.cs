using System;
using System.Collections.Generic;
using System.Text;

namespace ProkeyCoinsInfoGrabber.Models
{
    class AppSettings
    {
        public Ethplorer Ethplorer { get; set; } = new Ethplorer();
    }
    class Ethplorer
    {
        public string ApiKey { get; set; } = string.Empty;
    }
}
