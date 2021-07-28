using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Quasar.Core.Data;

namespace Quasar.Core.Native
{
    public class BlazorStorageExternal<T> : IDisposable
    {
        private readonly FileStream _fileStream;
        private readonly string _fileName;

        public BlazorStorageExternal()
        {
            var type = typeof(T);
            _fileName = type.FullName + ".json";

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string file = Path.Combine(folderPath, _fileName);

            _fileStream = File.Open(file, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        
        public T ReadBufferContent()
        {
            long length = _fileStream.Length;
            byte[] buffer = new byte[length];
            _fileStream.Read(buffer, 0, (int) length);

            string json = Encoding.UTF8.GetString(buffer);

            return JsonConvert.DeserializeObject<T>(json);
        }

        public void WriteBufferContent(T obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            byte[] bytes = Encoding.UTF8.GetBytes(json);

            _fileStream.Write(bytes, 0, bytes.Length);
        }

        public void Dispose()
        {
            _fileStream?.Dispose();
        }
    }
}
