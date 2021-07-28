using System;
using System.Collections.Generic;
using System.Text;
using Quasar.Core;

namespace Quasar.Core.Native
{ 
    public class BlazorMobilePlatform : IPlatform
    {
        public bool IsBlazorServer => false;
        public bool IsBlazorMobile => true;
    }
}
