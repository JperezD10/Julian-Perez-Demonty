using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Seguridad
{
    public class Seguridad
    {
        //AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
        /*public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
       {
           byte[] encryptedBytes = null;
           byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
           using (MemoryStream ms = new MemoryStream())
           {
               using (RijndaelManaged AES = new RijndaelManaged())
               {
                   AES.KeySize = 256;
                   AES.BlockSize = 128;
                   var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                   AES.Key = key.GetBytes(AES.KeySize / 8);
                   AES.IV = key.GetBytes(AES.BlockSize / 8);
                   AES.Mode = CipherMode.CBC;
                   using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                   {
                       cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                       cs.Close();
                   }
                   encryptedBytes = ms.ToArray();
               }
           }
           return encryptedBytes;
       }

       public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
       {
           byte[] decryptedBytes = null;
           byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
           using (MemoryStream ms = new MemoryStream())
           {
               using (RijndaelManaged AES = new RijndaelManaged())
               {
                   AES.KeySize = 256;
                   AES.BlockSize = 128;
                   var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                   AES.Key = key.GetBytes(AES.KeySize / 8);
                   AES.IV = key.GetBytes(AES.BlockSize / 8);
                   AES.Mode = CipherMode.CBC;
                   using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                   {
                       cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                       cs.Close();
                   }
                   decryptedBytes = ms.ToArray();
               }
           }
           return decryptedBytes;
       }*/
        public String generateSalt(String salt)
        {
            //var rng = new RNGCryptoServiceProvider();
            //var buff = new byte[Encoding.UTF8.GetBytes(salt)];
            byte[] buff = Encoding.UTF8.GetBytes(salt);
            //rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        public String generateSHA256(String input, String salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed SHA256 = new SHA256Managed();
            byte[] hash = SHA256.ComputeHash(bytes);
            return ByteArrayToHexString(hash);
        }
        public String generarHash(String toHash, String username)
        {
            String salt = generateSalt(username);
            String hashedPass = generateSHA256(toHash, salt);
            //generalHashedPass = hashedPass;
            return hashedPass;
        }

       
        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        /*public String returnEncrypted(string key)
        {
            String encrypted = Encoding.Default.GetString(encrypt(generalHashedPass, key));
            return encrypted;
        }
        String generalHashedPass;


        public String returnDecrypted(string encrypted, string key)
        {
            String decrypted = Encoding.Default.GetString(decrypt(encrypted, key));
            return decrypted;
        }
        public byte[] encrypt(string hashed, string key)
        {
            aesCryptoServiceProvider.Mode = CipherMode.CBC;
            aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            aesCryptoServiceProvider.KeySize = 256;
            aesCryptoServiceProvider.BlockSize = 128;
            //aesCryptoServiceProvider.GenerateIV();
            aesCryptoServiceProvider.IV = Encoding.Default.GetBytes(key);
            aesCryptoServiceProvider.Key = Encoding.Default.GetBytes(key);
            byte[] encrypted = null;
            byte[] plainContent = Encoding.Default.GetBytes(hashed);
            using (var memStream = new MemoryStream())
            {
                CryptoStream cryptoStream = new CryptoStream(memStream, aesCryptoServiceProvider.CreateEncryptor(),
                    CryptoStreamMode.Write);
                cryptoStream.Write(plainContent, 0, plainContent.Length);
                cryptoStream.FlushFinalBlock();
                cryptoStream.Close();
                encrypted = memStream.ToArray();
            }
            return encrypted;
        }

        public byte[] decrypt(string encrypted, string key)
        {
            aesCryptoServiceProvider.Mode = CipherMode.CBC;
            aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            aesCryptoServiceProvider.KeySize = 128;
            aesCryptoServiceProvider.BlockSize = 128;
            //aesCryptoServiceProvider.GenerateIV();
            aesCryptoServiceProvider.IV = Encoding.Default.GetBytes(key);
            aesCryptoServiceProvider.Key = Encoding.Default.GetBytes(key);
            byte[] encryptedBytes = Encoding.Default.GetBytes(encrypted);
            byte[] decryptedBytes = null;
            using(var memStream = new MemoryStream())
            {
                CryptoStream cryptoStream = new CryptoStream(memStream, aesCryptoServiceProvider.CreateDecryptor(),
                    CryptoStreamMode.Write);
                cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                //cryptoStream.FlushFinalBlock();
                //cryptoStream.Close();
                decryptedBytes = memStream.ToArray();
            }
            return decryptedBytes;
        }*/
    }
}
