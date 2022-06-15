using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary
{
    public class FccClass
    {
        public string NonAsyncMethod()
        {
            return "result";
        }
        public async Task<string> AsyncMethod()
        {
            return "result";
        }
    }
}
