using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public class Crypto
    {
        
        public RichTextBox textBox;
        public TextBox passwordBox;
        public byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public int BlockSize = 128;

        public static string Encrypt(RichTextBox textBox, TextBox passwordBox)
        {
            
            byte[] cipherData;
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(passwordBox.Text);
            aes.GenerateIV();
            aes.Mode = CipherMode.CBC;
            ICryptoTransform cipher = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, cipher, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(textBox);
                    }
                }

                cipherData = ms.ToArray();
            }

            byte[] combinedData = new byte[aes.IV.Length + cipherData.Length];
            Array.Copy(aes.IV, 0, combinedData, 0, aes.IV.Length);
            Array.Copy(cipherData, 0, combinedData, aes.IV.Length, cipherData.Length);
            return Convert.ToBase64String(combinedData);
        }

        public static string Decrypt(string combinedString, string keyString)
        {
            string textBox;
            byte[] combinedData = Convert.FromBase64String(combinedString);
            Aes aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(keyString);
            byte[] iv = new byte[aes.BlockSize / 8];
            byte[] cipherText = new byte[combinedData.Length - iv.Length];
            Array.Copy(combinedData, iv, iv.Length);
            Array.Copy(combinedData, iv.Length, cipherText, 0, cipherText.Length);
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform decipher = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream(cipherText))
            {
                using (CryptoStream cs = new CryptoStream(ms, decipher, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        textBox = sr.ReadToEnd();
                    }
                }

                return textBox;
            }
        }

        //public void Encrypt(RichTextBox textBox)
        //{
        //    byte[] bytes = Encoding.Unicode.GetBytes(textBox.Text);
        //    //Encrypt
        //    SymmetricAlgorithm crypt = Aes.Create();
        //    HashAlgorithm hash = MD5.Create();
        //    crypt.BlockSize = BlockSize;
        //    crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passwordBox.Text));
        //    crypt.IV = IV;



        //    using (MemoryStream memoryStream = new MemoryStream())
        //    {
        //        using (CryptoStream cryptoStream =
        //           new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
        //        {
        //            cryptoStream.Write(bytes, 0, bytes.Length);
        //        }
        //        Form1 f1 = new Form1();
        //        textBox.Text = Convert.ToBase64String(memoryStream.ToArray());
        //    }
        //}

        //public void Decrypt(RichTextBox textBox)
        //{

        //    byte[] bytes = Convert.FromBase64String(textBox.Text);
        //    SymmetricAlgorithm crypt = Aes.Create();
        //    HashAlgorithm hash = MD5.Create();
        //    crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(passwordBox.Text));
        //    crypt.IV = IV;

        //    using (MemoryStream memoryStream = new MemoryStream(bytes))
        //    {
        //        using (CryptoStream cryptoStream =
        //           new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
        //        {
        //            byte[] decryptedBytes = new byte[bytes.Length];
        //            cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
        //            textBox.Text = Encoding.Unicode.GetString(decryptedBytes);
        //        }
        //    }
        //}


    }
    
}
