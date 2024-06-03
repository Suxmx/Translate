using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate2.ExtendFunction;

namespace Translate2.MemBase
{
    public class MemoryBase
    {
        private Dictionary<string, string> memoryDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

    }
}