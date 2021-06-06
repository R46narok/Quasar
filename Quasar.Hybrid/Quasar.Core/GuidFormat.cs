using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core
{
    public static class GuidFormat
    {
        private const int MacByteWidth = 6;

        public static byte[] ToMac(this Guid guid)
        {
            byte[] bytes = guid.ToByteArray();
            byte[] output = new byte[MacByteWidth];

            Array.Copy(bytes, 10, output, 0, MacByteWidth);

            return output;
        }

        public static string ToMacString(this Guid guid)
        {
            byte[] bytes = guid.ToMac();
            return BitConverter.ToString(bytes);
        }
    }
}
