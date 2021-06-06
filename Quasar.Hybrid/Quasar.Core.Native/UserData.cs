using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quasar.Core.Native
{
    public class UserData
    {
        private const string UserDataPath = "data/user.json";

        private readonly FileStream _fstream;

        private int ReadEntireBuffer()
        {
            long length = _fstream.Length;
            if (length != 0)
            {
                byte[] bytes = new byte[length];
                return _fstream.Read(bytes, 0, (int)length);
            }

            return -1;
        }

        public UserData()
        {
            _fstream = File.Open(UserDataPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            ReadEntireBuffer();
        }
    }
}
