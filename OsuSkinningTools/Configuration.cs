using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSkinningTools
{
    class Configuration
    {
        public string WorkingDirectory { get; set; }
        public float ResizeScale { get; set; } = 0.5f;
        public string HighResPattern { get; set; } = "@2x";
    }
}
