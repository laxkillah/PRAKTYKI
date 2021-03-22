﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public class Crypto : Form
    {
        Form1 form1;
        Aes aes = new AesCryptoServiceProvider();
        //public static string Encrypt(string plainText, string keyString)
        //{
        //    byte[] cipherData;
        //    Aes aes = Aes.Create();
        //    aes.Key = Encoding.UTF8.GetBytes(keyString);
        //    aes.GenerateIV();
        //    aes.Mode = CipherMode.CBC;
        //    ICryptoTransform cipher = aes.CreateEncryptor(aes.Key, aes.IV);

        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        using (CryptoStream cs = new CryptoStream(ms, cipher, CryptoStreamMode.Write))
        //        {
        //            using (StreamWriter sw = new StreamWriter(cs))
        //            {
        //                sw.Write(plainText);
        //            }
        //        }

        //        cipherData = ms.ToArray();
        //    }

        //    byte[] combinedData = new byte[aes.IV.Length + cipherData.Length];
        //    Array.Copy(aes.IV, 0, combinedData, 0, aes.IV.Length);
        //    Array.Copy(cipherData, 0, combinedData, aes.IV.Length, cipherData.Length);
        //    return Convert.ToBase64String(combinedData);
        //}

        //public static string Decrypt(string combinedString, string keyString)
        //{
        //    string plainText;
        //    byte[] combinedData = Convert.FromBase64String(combinedString);
        //    Aes aes = Aes.Create();
        //    aes.Key = Encoding.UTF8.GetBytes(keyString);
        //    byte[] iv = new byte[aes.BlockSize / 8];
        //    byte[] cipherText = new byte[combinedData.Length - iv.Length];
        //    Array.Copy(combinedData, iv, iv.Length);
        //    Array.Copy(combinedData, iv.Length, cipherText, 0, cipherText.Length);
        //    aes.IV = iv;
        //    aes.Mode = CipherMode.CBC;
        //    ICryptoTransform decipher = aes.CreateDecryptor(aes.Key, aes.IV);

        //    using (MemoryStream ms = new MemoryStream(cipherText))
        //    {
        //        using (CryptoStream cs = new CryptoStream(ms, decipher, CryptoStreamMode.Read))
        //        {
        //            using (StreamReader sr = new StreamReader(cs))
        //            {
        //                plainText = sr.ReadToEnd();
        //            }
        //        }

        //        return plainText;
        //    }
        //}
        private int BlockSize = 128;
        public void Encrypt(RichTextBox textBox, TextBox passwordBox)
        {
            
            if (passwordBox.Text == "") return;
            byte[] bytes = Encoding.Unicode.GetBytes(textBox.Text);
            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm sha256Hash = SHA256.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(passwordBox.Text));
            aes.GenerateIV();
            crypt.IV = aes.IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                    new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                        cryptoStream.Write(bytes, 0, bytes.Length);
                }
                textBox.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        public void Decrypt(RichTextBox textBox, TextBox passwordBox)
        {

            byte[] bytes = Convert.FromBase64String(textBox.Text);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm sha256Hash = SHA256.Create();
            crypt.Key = sha256Hash.ComputeHash(Encoding.Unicode.GetBytes(passwordBox.Text));
            crypt.IV = aes.IV;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    textBox.Text = Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }


    }
    
}
