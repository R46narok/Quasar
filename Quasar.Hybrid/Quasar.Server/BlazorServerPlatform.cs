using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quasar.Core;

namespace Quasar.Server
{
    public class BlazorServerPlatform : IPlatform
    {
        public bool IsBlazorServer => true;
        public bool IsBlazorMobile => false;
    }
}
