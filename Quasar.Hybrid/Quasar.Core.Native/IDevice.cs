using System.Collections.Generic;
using System.Text;

namespace Quasar.Core.Native
{
    public interface IDevice
    {
        int Generation { get; }
        bool IsCompatibleWith();
    }
}
