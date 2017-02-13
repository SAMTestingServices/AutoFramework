using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace System
//namespace HIPTargetedRegression.Helpers
{
    public static class DecryptString
    {
        public static string Decrypt(this string encryptedData)
        {
            byte[] key = { 173, 247, 19, 211, 124, 26, 85, 45, 114, 184, 27, 162, 37, 112, 222, 209, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
            byte[] vector = { 146, 164, 91, 211, 23, 3, 113, 119, 231, 121, 221, 112, 79, 32, 114, 156 };

            RijndaelManaged rm = new RijndaelManaged();
            var decryptor = rm.CreateDecryptor(key, vector);
            var encoder = new UTF8Encoding();

            return encoder.GetString(Transform(Convert.FromBase64String(encryptedData), decryptor));
        }

        private static byte[] Transform(byte[] buffer, ICryptoTransform transform)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(stream, transform, CryptoStreamMode.Write))
                {
                    cs.Write(buffer, 0, buffer.Length);
                }
                return stream.ToArray();
            }
        }
    }
}