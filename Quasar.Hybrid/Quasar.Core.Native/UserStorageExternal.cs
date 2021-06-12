using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Quasar.Core.DataAccess;

namespace Quasar.Core.Native
{
    public class UserStorageExternal : IDisposable
    {
        private const string UserCredentialsFile = "user.json";

        private readonly FileStream _userCredentialStream;

        public UserStorageExternal()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string file = Path.Combine(folderPath, UserCredentialsFile);

            _userCredentialStream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public User ReadBufferContent()
        {
            long length = _userCredentialStream.Length;
            byte[] buffer = new byte[length];
            _userCredentialStream.Read(buffer, 0, (int) length);

            string json = Encoding.UTF8.GetString(buffer);

            return JsonConvert.DeserializeObject<User>(json);
        }

        public void WriteBufferContent(User user)
        {
            string json = JsonConvert.SerializeObject(user);
            byte[] bytes = Encoding.UTF8.GetBytes(json);

            _userCredentialStream.Write(bytes, 0, bytes.Length);
        }

        public void Dispose()
        {
            _userCredentialStream?.Dispose();
        }
    }
}
