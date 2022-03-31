using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NewJson
{
        // <wf>
        public class Chars
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int HP { get; set; }
            public int Infection { get; set; }
            public string Desc { get; set; }
            public string Profile { get; set; }
        }
        // </wf>
}
