using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EZLib
{
    internal static class Cryptography
    {
        public static string Encrypt(string plainText, byte[] key, byte[] iv)
        {
            var encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;

            encryptor.Key = key;
            encryptor.IV = iv;

            var memoryStream = new MemoryStream();

            var aesEncryptor = encryptor.CreateEncryptor();

            var cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            var plainBytes = Encoding.ASCII.GetBytes(plainText);

            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            cryptoStream.FlushFinalBlock();

            var cipherBytes = memoryStream.ToArray();

            memoryStream.Close();
            cryptoStream.Close();

            var cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);
            return cipherText;
        }

        public static string DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            var encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;

            encryptor.Key = key;
            encryptor.IV = iv;

            var memoryStream = new MemoryStream();

            var aesDecryptor = encryptor.CreateDecryptor();

            var cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            var plainText = string.Empty;

            try
            {
                var cipherBytes = Convert.FromBase64String(cipherText);

                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                cryptoStream.FlushFinalBlock();

                var plainBytes = memoryStream.ToArray();

                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                memoryStream.Close();
                cryptoStream.Close();
            }

            return plainText;
        }
    }
}