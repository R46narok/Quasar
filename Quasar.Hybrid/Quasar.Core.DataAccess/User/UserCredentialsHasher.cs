﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Quasar.Core.DataAccess
{
    /// <summary>
    /// Uses PBKDF.
    /// </summary>
    public static class UserCredentialsHasher
    {
        public static byte[] GenerateSalt(int length)
        {
            var bytes = new byte[length];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }

            return bytes;
        }

        public static byte[] GenerateHash(byte[] password, byte[] salt, int iterations, int length)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return deriveBytes.GetBytes(length);
            }
        }
    }
}
