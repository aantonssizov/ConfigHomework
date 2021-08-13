using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigHomework
{
    public class UserConfig
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public bool IsActive { get; set; }
        public AccountConfig AccountConfig { get; set; }
    }
}
