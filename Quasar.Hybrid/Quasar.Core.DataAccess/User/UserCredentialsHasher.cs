using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Quasar.Core.DataAccess
{
    /// <summary>
    /// This class is used to convert plain text passwords into an
    /// irreversible hash. The algorithm used is PBKDF.
    /// </summary>
    public static class UserCredentialsHasher
    {
        /// <summary>
        /// Generates a dynamic salt for each user on creation.
        /// Used to prevent huge leaks of plain text passwords in an
        /// eventual data breach.
        /// </summary>
        /// <param name="length">Byte width of the required salt - preferred 64 bytes.</param>
        /// <returns>Null if the length specified is invalid.</returns>
        public static byte[] GenerateSalt(int length)
        {
            if (length >= 0)
            {
                var bytes = new byte[length];

                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(bytes);
                }

                return bytes;
            }

            return null;
        }

        /// <summary>
        /// Converts a plain text password into an irreversible hash.
        /// </summary>
        /// <param name="password">Plain text password in bytes.</param>
        /// <param name="salt">Generated dynamic salt from GenerateSalt(...).</param>
        /// <param name="iterations">Number of iterations - the grater it is, the harder it
        /// will be for people with malicious intent to bruteforce the hash.</param>
        /// <param name="length">Length of the password.</param>
        /// <returns>The converted password.</returns>
        public static byte[] GenerateHash(byte[] password, byte[] salt, int iterations, int length)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return deriveBytes.GetBytes(length);
            }
        }
    }
}
