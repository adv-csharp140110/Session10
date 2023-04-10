using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Balnce { get; set; }
    }
}
