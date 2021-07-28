using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core
{
    public interface IPlatform
    {
        bool IsBlazorServer { get; }
        bool IsBlazorMobile { get; }
    }
}
